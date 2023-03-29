using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.Logging;
using Mysqlx.Crud;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Reszke
{

    //static class containing methods for user management


    static class ClientManagement
    {

        static int addClientPrivilege = 1;

        public static int RegisterClient(ref UserSession userSession, string newName,
            string newSurname, string newPhoneNumber, string newPostalCode,
            string newCity, string newStreet, string newHouseNumber,
            string newApartmentNumber, string newEmail)
        {
            /*
            * - FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - not logged in
            * 3 - no permissions
            * 4 - sql/other error
            * 5 - invalid/empty parameters
            */


            if (newName == "" || newSurname == "" || newPhoneNumber == "" || newPostalCode == "" ||
                newCity == "" || newStreet == ""  || newHouseNumber == "" ||
                newApartmentNumber == "" || newEmail == "")
            {
                //invalid parameters
                Debugger.CreateLogMessage("Błędne lub puste parametry przy próbie dodania nowego klienta");
                return 5;
            }
            else if (!userSession.IsLoggedIn())
            {
                //not logged in
                Debugger.CreateLogMessage("Próba rejestracji nowego klinta nie będąc zalogowanym");
                return 1;
            }
            else if (userSession.GetPrivilege() < addClientPrivilege || userSession.GetPrivilege() < addClientPrivilege)
            {
                //no permissions 
                Debugger.CreateLogMessage($"Próba utworzenia klienta bez uprawnień, użytkownik: {userSession.GetLogin()}");
                return 3;
            }
            else
            {
                //sanitizing values
                string newNameSanitized = DatabaseGateway.SanitizeString(newName);
                string newSurnameSanitized = DatabaseGateway.SanitizeString(newSurname);
                string newPhoneNumberSanitized = DatabaseGateway.SanitizeString(newPhoneNumber);
                string newPostalCodeSanitized = DatabaseGateway.SanitizeString(newPostalCode);
                string newCitySanitized = DatabaseGateway.SanitizeString(newCity);
                string newStreetSanitized = DatabaseGateway.SanitizeString(newStreet);
                string newHouseNumberSanitized = DatabaseGateway.SanitizeString(newHouseNumber);
                string newApartmentNumberSanitized = DatabaseGateway.SanitizeString(newApartmentNumber);
                string newEmailSanitized = DatabaseGateway.SanitizeString(newEmail);

                try
                {
                    
                    //inserting data

                    string addCustomerSql = $"INSERT INTO `customers` (`customerID`, `firstName`, `lastName`, `phoneNr`, `postalCode`, `city`, `street`, `houseNumber`, `apartmentNumber`, `email`) VALUES(NULL, '{newNameSanitized}', '{newSurnameSanitized}', '{newPhoneNumberSanitized}', '{newPostalCodeSanitized}', '{newCitySanitized}', '{newStreetSanitized}', '{newHouseNumberSanitized}', '{newApartmentNumberSanitized}', '{newEmailSanitized}');";
                    int addUserResult = DatabaseGateway.ExecuteNonQueryCommand(addCustomerSql, ref userSession.GetDatabaseConnectionRef());
                    if (addUserResult == 1)
                    {
                        //success
                        return 0;
                    }
                    else
                    {
                        //sql/other error
                        Debugger.CreateLogMessage($"Błąd przy rejestracji nowego klienta");
                        return 4;
                    }

                    
                }
                catch (Exception e)
                {
                    //sql/other error
                    Debugger.CreateLogMessage($"Błąd przy rejestracji nowego klienta ({e.Message})");
                    return 4;
                }
            }
        }


        public static int DeleteClient(ref UserSession userSession, int idToDelete)
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


            if (idToDelete < 0)
            {
                //invalid parameters
                Debugger.CreateLogMessage("Błędny lub pusty parametr przy próbie usunięcia klienta");
                return 5;
            }
            else if (!userSession.IsLoggedIn())
            {
                //not logged in
                Debugger.CreateLogMessage("Próba rejestracji nowego klienta nie będąc zalogowanym");
                return 1;
            }
            else if (userSession.GetPrivilege() < addClientPrivilege)
            {
                //no permissions 
                Debugger.CreateLogMessage($"Próba usinięcia klienta bez uprawnień, użytkownik: {userSession.GetLogin()}");
                return 3;
            }
            else
            {
                

                try
                { 
                    string userExistSql = $"SELECT COUNT(*) FROM `customers` WHERE customerID = {idToDelete}";
                    int userExistResult = int.Parse(DatabaseGateway.ExecuteScalarCommand(userExistSql, ref userSession.GetDatabaseConnectionRef()));
                    if (userExistResult != 1)
                    {
                        //no such user
                        Debugger.CreateLogMessage($"Błąd przy usuwaniu klienta: nie ma takiego klinta o id {idToDelete}");
                        return 6;
                    }
                    else
                    {
                        string userDeleteSql = $"DELETE FROM customers WHERE `customers`.`customerID` = {idToDelete}";
                        int userDeleteResult = DatabaseGateway.ExecuteNonQueryCommand(userDeleteSql, ref userSession.GetDatabaseConnectionRef());
                        if (userDeleteResult != 1)
                        {
                            //sql/other error
                            Debugger.CreateLogMessage($"Błąd przy usuwaniu klienta");
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
                    Debugger.CreateLogMessage($"Błąd przy usuwaniu klienta: {e.Message}. ");
                    return 4;
                }

            }

        }

        

        
    }
}
