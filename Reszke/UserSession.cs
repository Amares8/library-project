using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Reszke
{
    internal class UserSession
    {
        //A class representing ongoing logged user session
        //loggedLogin being equal to "" means user is not logged in

        //id set to -1 means that user is not logged in
        private int loggedID;
        private string loggedLogin;
        private int privilege;
        private string firstName;
        private string lastName;

        private MySqlConnection databaseConnection;


        public UserSession (ref MySqlConnection dbConnection)
        {
            //Default values after creating object instance
            loggedID = -1;
            loggedLogin = "";
            privilege = 0;
            firstName = "";
            lastName = "";
            databaseConnection = dbConnection;
        }


        public string GetLogin()
        {
            return this.loggedLogin;
        }

        public int GetPrivilege()
        {
            return this.privilege;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public int GetID()
        {
            return this.loggedID;
        }

        public bool IsLoggedIn()
        {
            if (loggedID == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }




        public int Login (string login, string password)
        {
            /*
            * - FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - already logged in
            * 2 - wrong login/password
            * 4 - sql/other error
            * 5 - invalid/empty parameters
            */

            if (login == "" || password == "")
            {
                //empty parameters
                return 5;
            }
            else if (IsLoggedIn())
            {
                //juz zalogowany
                return 1;
            }
            else
            {
                try
                {
                    //Przetwarzanie podanego loginu i hasła,
                    //login ma być zabezpieczony przed wstrzykiwaniem sql, haslo ma być zahaszowane

                    string loginSanitized = DatabaseGateway.SanitizeString(login);
                    string passwordHash = DatabaseGateway.GetStringSha256Hash(password);


                    //Sprawdzenie czy login i hasło są zgodne
                    string userExistTextSql = $"SELECT COUNT(*) FROM employees WHERE login = '{loginSanitized}' AND password = '{passwordHash}'";
                    int userExistTestResult = int.Parse(DatabaseGateway.ExecuteScalarCommand(userExistTextSql, ref databaseConnection));

                    if (userExistTestResult != 1)
                    {
                        //wrong password or login
                        Debugger.CreateLogMessage($"Podano zły login lub hasło przy próbie zalogowania użytkownika {login}");
                        return 2;
                    }
                    else
                    {
                        //udane logowanie

                        //pobieranie danych z baza o zalogowanym uzytkowniku
                        string loadUserDataSql = $"SELECT employeeID, firstName, lastName, privilege FROM employees WHERE login = '{loginSanitized}'";
                        string[,] userData = DatabaseGateway.ExecuteSelectCommand(loadUserDataSql, ref databaseConnection);
                        loggedID = int.Parse(userData[0, 0]);
                        loggedLogin = loginSanitized;
                        firstName = userData[0, 1];
                        lastName = userData[0, 2];
                        privilege = int.Parse(userData[0, 3]);

                        return 0;
                        
                    }
                }
                catch (Exception e)
                {
                    //sql / other error
                    Debugger.CreateLogMessage($"Błąd przy próbie logowania. Użytkownik: {login}. ({e.Message})");
                    return 4;
                }
            }




        }

        public int Logout()
        {
            /*
            * - FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - not logged in
            */

            if (!IsLoggedIn())
            {
                //nie jest zalogowany
                return 1;
            }
            else
            {
                loggedID = -1;
                loggedLogin = "";
                privilege = 0;
                firstName = "";
                lastName = "";
                return 0;
            }
            
        }

        public int ChangePassword(string oldPassword, string newPassword)
        {

            /*
            * - FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - already logged in
            * 2 - wrong password
            * 4 - sql/other error
            * 5 - invalid/empty parameters
            */


            if (loggedLogin == "")
            {
                //not logged in
                return 1;
            }
            else if (oldPassword == "" || newPassword == "")
            {
                return 5;
            }
            try
            {
                string oldPasswordHash = DatabaseGateway.GetStringSha256Hash(oldPassword);
                string newPasswordHash = DatabaseGateway.GetStringSha256Hash(newPassword);
                
                string sql = $"SELECT COUNT(*) FROM employees WHERE employeeID = {loggedID} AND password = '{oldPasswordHash}';";
                int passwordCheckResult = int.Parse(DatabaseGateway.ExecuteScalarCommand(sql, ref databaseConnection));
                    
                if (passwordCheckResult == 1)
                {
                    
                    string changePasswordSql = $"UPDATE employees SET password = '{newPasswordHash}' WHERE employeeID = {loggedID}";

                    int passwordChangeResult = DatabaseGateway.ExecuteNonQueryCommand(changePasswordSql, ref databaseConnection);
                    
                    if (passwordChangeResult == 1)
                    {
                        //success
                        return 0;
                    }
                    else
                    {
                        //sql/other error
                        Debugger.CreateLogMessage($"Błąd przy zmianie hasła, użytkownik {loggedLogin}");
                        return 4;
                    }
                }
                else
                {
                    //wrong password
                    Debugger.CreateLogMessage($"Podano błędne hasło przy zmianie hasła, użytkownik: {loggedLogin}");
                    return 2;
                }
            }
            catch (Exception e)
            {
                //sql/other error
                Debugger.CreateLogMessage("Błąd przy zmianie hasła " + e.Message);
                return 4;
            }

        }




    }
}
