using Microsoft.VisualBasic.Logging;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Reszke
{

    //static class containing methods for user management


    static class UserManagement
    {

        static int maxPrivilege = 3;
        static int addUserPrivilege = 2;
        static int resetPasswordPrivilege = 2;
        static string defaultPassword = "password";

        public static int RegisterUser (ref UserSession userSession, string newLogin, string newName, string newSurname,
                                        string newEmail, int newJobTitle, string newPassword, int newPrivilege)
        {
           /*
           * - FUNCTION RETURN VALUES -
           * 0 - successfull
           * 1 - not logged in
           * 3 - no permissions
           * 4 - sql/other error
           * 5 - invalid/empty parameters
           * 6 - user already exists
           */


            if (newLogin == "" || newName == "" || newSurname == "" || newEmail == "" ||
                newJobTitle < 0 || newPassword == "" || newPrivilege < 0 || newPrivilege > maxPrivilege)
            {
                //invalid parameters
                Debugger.CreateLogMessage("Błędne lub puste parametry przy próbie dodania nowego pracownika");
                return 5;
            }
            else if (!userSession.IsLoggedIn())
            {
                //not logged in
                Debugger.CreateLogMessage("Próba rejestracji nowego użytkownika nie będąc zalogowanym");
                return 1;
            }
            else if (userSession.GetPrivilege() < addUserPrivilege || userSession.GetPrivilege() < newPrivilege)
            {
                //no permissions 
                Debugger.CreateLogMessage($"Próba utworzenia konta użytkownika bez uprawnień, użytkownik: {userSession.GetLogin()}");
                return 3;
            }
            else
            {
                //sanitizing values
                string newLoginSanitized = DatabaseGateway.SanitizeString(newLogin);
                string newNameSanitized = DatabaseGateway.SanitizeString(newName);
                string newSurnameSanitized = DatabaseGateway.SanitizeString(newSurname);
                string newEmailSanitized = DatabaseGateway.SanitizeString(newEmail);
                //hashong password
                string newPasswordHash = DatabaseGateway.GetStringSha256Hash(newPassword);

                

                
                
                try
                {
                    string existCheckSql = $"SELECT COUNT(*) FROM `employees` WHERE login = '{newLoginSanitized}'";
                    int existCheckResult = int.Parse(DatabaseGateway.ExecuteScalarCommand(existCheckSql, ref userSession.GetDatabaseConnectionRef()));

                    if (existCheckResult == -1)
                    {
                        //sql/other error
                        Debugger.CreateLogMessage($"Błąd przy rejestracji nowego pracownika");
                        return 4;
                    }
                    else if (existCheckResult != 0)
                    {
                        //username already taken
                        Debugger.CreateLogMessage($"Błąd przy rejestracji nowego pracownika: Użytkownik z loginem {newLoginSanitized} już istnieje!");
                        return 6;
                    }
                    else
                    {
                        //inserting data
                        string addUserSql = $"INSERT INTO `employees` (`employeeID`, `login`, `firstName`, `lastName`, `email`, `jobTitle`, `password`, `privilege`) VALUES (NULL, '{newLoginSanitized}', '{newNameSanitized}', '{newSurnameSanitized}', '{newEmailSanitized}', {newJobTitle}, '{newPasswordHash}', {newPrivilege});";
                        int addUserResult = DatabaseGateway.ExecuteNonQueryCommand(addUserSql, ref userSession.GetDatabaseConnectionRef());
                        if (addUserResult == 1)
                        {
                            //success
                            return 0;
                        }
                        else
                        {
                            //sql/other error
                            Debugger.CreateLogMessage($"Błąd przy rejestracji nowego pracownika");
                            return 4;
                        }

                    }
                }
                catch (Exception e)
                {
                    //sql/other error
                    Debugger.CreateLogMessage($"Błąd przy rejestracji nowego pracownika ({e.Message})");
                    return 4;
                }
            }
        }

        public static int DeleteUser (ref UserSession userSession, string loginToDelete)
        {
            /*
             * - FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters
             * 6 - user doesn't exist
             */


            if (loginToDelete == "" )
            {
                //invalid parameters
                Debugger.CreateLogMessage("Błędny lub pusty parametr przy próbie usunięcia pracownika");
                return 5;
            }
            else if (!userSession.IsLoggedIn())
            {
                //not logged in
                Debugger.CreateLogMessage("Próba rejestracji nowego użytkownika nie będąc zalogowanym");
                return 1;
            }
            else if (userSession.GetPrivilege() < addUserPrivilege)
            {
                //no permissions 
                Debugger.CreateLogMessage($"Próba usinięcia konta użytkownika bez uprawnień, użytkownik: {userSession.GetLogin()}");
                return 3;
            }
            else
            {
                string loginToDeleteSanitized = DatabaseGateway.SanitizeString(loginToDelete);

                try
                {
                    string userExistSql = $"SELECT COUNT(*) FROM `employees` WHERE login = '{loginToDeleteSanitized}'";
                    int userExistResult = int.Parse(DatabaseGateway.ExecuteScalarCommand(userExistSql, ref userSession.GetDatabaseConnectionRef()));
                    if (userExistResult != 1)
                    {
                        //no such user
                        Debugger.CreateLogMessage($"Błąd przy usuwaniu pracownika: nie ma takiego użytkownika jak {loginToDeleteSanitized}");
                        return 6;
                    }
                    else
                    {
                        string userDeleteSql = $"DELETE FROM employees WHERE `employees`.`login` = '{loginToDeleteSanitized}'";
                        int userDeleteResult = DatabaseGateway.ExecuteNonQueryCommand(userDeleteSql, ref userSession.GetDatabaseConnectionRef());
                        if (userDeleteResult != 1)
                        {
                            //sql/other error
                            Debugger.CreateLogMessage($"Błąd przy usuwaniu pracownika");
                            return 4;
                        }
                        else
                        {
                            //success
                            return 0;
                        }
                    }

                }
                catch (Exception e)
                {
                    //sql/other error
                    Debugger.CreateLogMessage($"Błąd przy usuwaniu pracownika: {e.Message}. ");
                    return 4;
                }
                
            }

        }

        public static int ResetUsersPassword(ref UserSession userSession, string loginToReset)
        {
            /*
             * - FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters
             * 6 - user doesn't exist
             */


            if (loginToReset == "")
            {
                //invalid parameters
                Debugger.CreateLogMessage("Błędny lub pusty parametr przy próbie resetu hasła");
                return 5;
            }
            else if (!userSession.IsLoggedIn())
            {
                //not logged in
                Debugger.CreateLogMessage("Próba resetu hasła nie będąc zalogowanym");
                return 1;
            }
            else if (userSession.GetPrivilege() < resetPasswordPrivilege)
            {
                //no permissions 
                Debugger.CreateLogMessage($"Próba resetu hasła, użytkownik: {userSession.GetLogin()}");
                return 3;
            }
            else
            {
                string loginToResetSanitized = DatabaseGateway.SanitizeString(loginToReset);
                try
                {
                    string userExistSql = $"SELECT COUNT(*) FROM `employees` WHERE login = '{loginToResetSanitized}'";
                    int userExistResult = int.Parse(DatabaseGateway.ExecuteScalarCommand(userExistSql, ref userSession.GetDatabaseConnectionRef()));
                    if (userExistResult != 1)
                    {
                        //no such user
                        Debugger.CreateLogMessage($"Błąd przy resetowaniu hasła: nie ma takiego użytkownika jak {loginToResetSanitized}");
                        return 6;
                    }
                    else
                    {
                        string newPasswordHash = DatabaseGateway.GetStringSha256Hash(defaultPassword);
                        string resetPasswordSql = $"UPDATE `employees` SET `password` = '{newPasswordHash}' WHERE `employees`.`login` = '{loginToResetSanitized}'";
                        int userDeleteResult = DatabaseGateway.ExecuteNonQueryCommand(resetPasswordSql, ref userSession.GetDatabaseConnectionRef());
                        if (userDeleteResult != 1)
                        {
                            //sql/other error
                            Debugger.CreateLogMessage($"Błąd przy resetowaniu hasła");
                            return 4;
                        }
                        else
                        {
                            //success
                            return 0;
                        }
                    }

                }
                catch (Exception e)
                {
                    //sql/other error
                    Debugger.CreateLogMessage($"Błąd przy resetowaniu hasła: {e.Message}. ");
                    return 4;
                }

            }
        
        }



        public static int FillEmployeesDataGrid(ref UserSession userSession, DataGridView dataGridView)
        {
            //funciotn tha fills dataGridView with employees data
            //returns: 0 - success, 1 - error

            //clear all data form grid viewo
            dataGridView.Rows.Clear();
            
            //getting lendings info from database
            string getEpmloyeesSql = "SELECT employeeID, login, firstName, lastName, email, jobTitle FROM employees";
            string[,] employeesSelectArray = DatabaseGateway.ExecuteSelectCommand(getEpmloyeesSql, ref userSession.GetDatabaseConnectionRef());


            //check for error
            if (employeesSelectArray == null)
            {
                return 1;
            }

            for (int i = 0; i < employeesSelectArray.GetLength(0); i++)
            {
                //creating new data grid row

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);


                //assigning values to row cells
                row.Cells[0].Value = employeesSelectArray[i, 0];       //employe id
                row.Cells[1].Value = employeesSelectArray[i, 1] + " "; //first name + lastname
                row.Cells[1].Value += employeesSelectArray[i, 2]; 
                row.Cells[2].Value += employeesSelectArray[i, 3]; //email
                switch(employeesSelectArray[i, 3]) // job title
                {
                    case "0":
                        row.Cells[3].Value = "stażysta";
                        break;
                    case "1":
                        row.Cells[3].Value = "informatyk";
                        break;
                    case "2":
                        row.Cells[3].Value = "księgowy";
                        break;
                    case "3":
                        row.Cells[3].Value = "kadrowy";
                        break;
                    case "4":
                        row.Cells[3].Value = "kierownik";
                        break;
                    case "5":
                        row.Cells[3].Value = "asystent";
                        break;
                    case "6":
                        row.Cells[3].Value = "nadzorca";
                        break;
                    case "7":
                        row.Cells[3].Value = "prezes";
                        break;
                    case "8":
                        row.Cells[3].Value = "bibliotkarz";
                        break;
                    default:
                        row.Cells[3].Value = "inny";
                        break;
                }
                row.Cells[5].Value += employeesSelectArray[i, 4]; //jobtitle ID


                



                //adding create row to dataGridViev passed in the parameter
                dataGridView.Rows.Add(row);

            }

            //retruning 0 as success code 
            return 0;

        }


    }
}
