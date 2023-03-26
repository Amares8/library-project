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

        public static int RegisterUser(ref UserSession userSession, string newLogin, string newName, string newSurname,
                                        string newEmail, int newJobTitle, string newPassword, int newPrivilege)
        {
            /*
           * - FUNCTION RETURN VALUES -
           * 0 - successfull
           * 1 - not logged in
           * 2 - wrong login/password
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
                    int existCheckResult = DatabaseGateway.ExecuteNonQueryCommand(existCheckSql, ref userSession.GetDatabaseConnectionRef());

                    if (existCheckResult == -1)
                    {
                        //sql/other error
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



        //public int DeleteUser (ref UserSession userSession, )
        {

        }
        //public int ResetUsersPassword()
        {

        }
    }
}
