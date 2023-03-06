using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public UserSession()
        {
            //Default values after creating object instance
            loggedID = -1;
            loggedLogin = "";
            accessLevel = 0;
            firstName = "";
            lastName = "";
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








    }
}
