using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Reszke
{
    internal class UserSession
    {
        //A class representing ongoing logged user session
        //loggedLogin being equal to "" means user is not logged in

        //id set to -1 means that user is not logged in
        private int loggedID;
        private string loggedLogin;
        private int accessLevel;
        private string firstName;
        private string lastName;

        private MySqlConnection databaseConnection;


        public UserSession (ref MySqlConnection dbConnection)
        {
            //Default values after creating object instance
            loggedID = -1;
            loggedLogin = "";
            accessLevel = 0;
            firstName = "";
            lastName = "";
            databaseConnection = dbConnection;
        }


        public string GetLogin()
        {
            return this.loggedLogin;
        }

        public int GetAccessLevel()
        {
            return this.accessLevel;
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
            return 4;
        }

        public int Logout()
        {
            loggedID = -1;
            loggedLogin = "";
            accessLevel = 0;
            firstName = "";
            lastName = "";
            return 0;
        }





    }
}
