using Mysqlx.Crud;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace Reszke
{
    static class LibraryManagement
    {

        static int bookLendPrivilege = 1;
        static int bookStockLevelModifyPrivilege = 1;
        static int bookAddPrivilege = 2;

        public static int LendBook(ref UserSession userSession, int bookID, int customerID, string lendingDate, string returnDate)
        {
             /*
             * - FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 2 - insufficient stock
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters
             */


            if (!userSession.IsLoggedIn())
            {
                //not logged in
                return 1;
            }
            if (bookID < 0 || customerID < 0 || !DatabaseGateway.IsValidSqlDate(lendingDate) || !DatabaseGateway.IsValidSqlDate(returnDate))
            {
                //invalid parameters
                return 5;
            }
            if (userSession.GetPrivilege() < bookLendPrivilege)
            {
                //no permissions
                Debugger.CreateLogMessage($"Próba wypozyczenia ksiazki bez uprawnien, uzytkownik {userSession.GetLogin()}");
                return 3;
            }

            string testStockQuanitySql = $"SELECT quantityInStock FROM books WHERE bookID = {bookID}";
            int bookStockQuantity = int.Parse(DatabaseGateway.ExecuteScalarCommand(testStockQuanitySql, ref userSession.GetDatabaseConnectionRef()));

            if (bookStockQuantity <= 0)
            {
                //insufficent stock
                return 2;
            }

            string lendBookSQL = $"INSERT INTO `lendings` (`lendingID`, `bookID`, `customerID`, `employeeID`, `lendingDate`, `returnDate`, `finalReturnedDate`, `statusID`) VALUES ('', {bookID}, {customerID}, {userSession.GetID()}, '{lendingDate}', '{returnDate}', NULL, 1)";
            int bookLendResult = DatabaseGateway.ExecuteNonQueryCommand(lendBookSQL, ref userSession.GetDatabaseConnectionRef());
            if (bookLendResult != 1)
            {
                //success
                return 4;
            }

            string bookDecrementSql = $"UPDATE books SET quantityInStock = quantityInStock-1 WHERE bookID = {bookID}";
            int bookDecrementResult = DatabaseGateway.ExecuteNonQueryCommand(bookDecrementSql, ref userSession.GetDatabaseConnectionRef());
            if (bookDecrementResult != 1)
            {
                //error
                return 4;
            }

            //success
            return 0;

        }

        public static int ReturnBook(ref UserSession userSession, int lendingID, string finalReturnDate)
        {

            /*
             * - FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters
             * 6 - book already returned / invalid status
             */

            if (!userSession.IsLoggedIn())
            {
                //not logged in
                return 1;
            }
            if (!DatabaseGateway.IsValidSqlDate(finalReturnDate))
            {
                //invalid parameters
                return 5;
            }
            if (lendingID < 0 || userSession.GetPrivilege() < bookLendPrivilege)
            {
                //no permissions
                Debugger.CreateLogMessage($"Próba udokumentowania zwrotu ksiazki bez uprawnien, uzytkownik {userSession.GetLogin()}");
                return 3;
            }


            //getting lending status
            string getStatusSql = $"SELECT statusID FROM lendings WHERE lendingID = {lendingID}";
            int lendingStatus = int.Parse(DatabaseGateway.ExecuteScalarCommand(getStatusSql, ref userSession.GetDatabaseConnectionRef()));

            if (lendingStatus != 1)
            {
                //book lending status not valid
                return 6;
            }


            string returnDateSql = $"SELECT DATE_FORMAT(returnDate, '%Y-%m-%d') AS new_date FROM lendings WHERE lendingID = {lendingID};";
            string returnDate = DatabaseGateway.ExecuteScalarCommand(returnDateSql, ref userSession.GetDatabaseConnectionRef());
            if (!DatabaseGateway.IsValidSqlDate(returnDate))
            {
                //no return date
                Debugger.CreateLogMessage($"Błąd pobierania teminu zwrotu wypozyczenia nr {lendingID}");
                return 4;
            }

            DateTime returnDateTime;
            DateTime finalReturnedDateTime;

            if (!DateTime.TryParse(returnDate, out returnDateTime))
            {
                Debugger.CreateLogMessage("Błąd konwersji daty");
                return 4;
                
            }
            if (!DateTime.TryParse(finalReturnDate, out finalReturnedDateTime))
            {
                Debugger.CreateLogMessage("Błąd konwersji daty");
                return 4;
            }

            int newLendingStatus;
            int lateReturnTest = DateTime.Compare(finalReturnedDateTime, returnDateTime);
            if (lateReturnTest  < 0)
            {
                newLendingStatus = 2;
            }
            else
            {
                newLendingStatus = 3;
            }

            Debugger.CreateLogMessage(finalReturnDate);
            string returnBookSql = $"UPDATE `lendings` SET finalReturnedDate='{finalReturnDate}', `statusID` = {newLendingStatus} WHERE `lendings`.`lendingID` = {lendingID}";
            int returnBookResult = DatabaseGateway.ExecuteNonQueryCommand(returnBookSql, ref userSession.GetDatabaseConnectionRef());
            if (returnBookResult != 1)
            {
                //error
                Debugger.CreateLogMessage("Błąd przy obsłudze zwrotu książki");
                return 4;
            }


            string bookIncrementSql = $"UPDATE books, lendings SET books.quantityInStock = quantityInStock + 1 WHERE books.bookID = lendings.bookID AND lendings.lendingID = {lendingID}";
            int bookQuantityIncrementResult = DatabaseGateway.ExecuteNonQueryCommand(bookIncrementSql, ref userSession.GetDatabaseConnectionRef());
            if (bookQuantityIncrementResult != 1)
            {
                //error
                Debugger.CreateLogMessage("Błąd przy zwiększeniu stanu magazynowego ksiązki");
                return 4;
            }

            //success
            return 0;

        }


        public static int ModifyBookStockLevel(ref UserSession userSession, int bookID, int modAmount)
        {
            /*
             * - FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters
             * 6 - insufficent stock
             */

            if (!userSession.IsLoggedIn())
            {
                //not logged in
                return 1;
            }
            if (bookID < 0)
            {
                //wrong parameters
                return 5;
            }
            if (userSession.GetPrivilege() < bookStockLevelModifyPrivilege)
            {
                //no privilege
                return 3;
            }

            string getStockLevelSql = $"SELECT quantityInStock FROM books WHERE bookID = {bookID}";
            int stockLevel = int.Parse(DatabaseGateway.ExecuteScalarCommand(getStockLevelSql, ref userSession.GetDatabaseConnectionRef()));

            string getTotalStockLevelSql = $"SELECT totalQuantityInStock FROM books WHERE bookID = {bookID}";
            int totalStockLevel = int.Parse(DatabaseGateway.ExecuteScalarCommand(getTotalStockLevelSql, ref userSession.GetDatabaseConnectionRef()));


            if (-modAmount > stockLevel)
            {
                //insifficent stock
                return 6;
            }

            string updateStockLevelSql = $"UPDATE `books` SET `quantityInStock` = {(stockLevel + modAmount)}, `totalQuantityInStock` = {(totalStockLevel + modAmount)} WHERE `books`.`bookID` = {bookID};";
            int stockLevelModResult = DatabaseGateway.ExecuteNonQueryCommand(updateStockLevelSql, ref userSession.GetDatabaseConnectionRef());
            

            if (stockLevelModResult != 1)
            {
                //sql/other error
                return 4;
            }


            //success
            return 0;


        }
        
        public static int AddNewBook (ref UserSession userSession, string bookName, int authorID, int publisherID, string releaseDate,
            int bookCategoryID, string bookDescription)
        {

            /*
             * - FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters

             */

            if (!userSession.IsLoggedIn())
            {
                //not logged in
                return 1;
            }
            if (bookName == "" || authorID < 0 || publisherID < 0 || !DatabaseGateway.IsValidSqlDate(releaseDate) || bookCategoryID < 0)
            {
                //wrong parameters
                return 5;
            }
            if (userSession.GetPrivilege() < bookAddPrivilege)
            {
                //no privilege
                return 3;
            }


            string bookNameSanitized = DatabaseGateway.SanitizeString(bookName);
            string bookDescriptionSanitized = DatabaseGateway.SanitizeString(bookDescription);

            string addNewBookSql =
            $"INSERT INTO `books`" +
            $"(`bookID`, `bookName`, `bookAuthorID`, `publisherID`, `releaseDate`, `bookCategoryID`, `bookDescription`, `quantityInStock`, `totalQuantityInStock`, `receivedBookDetailID`)" +
            $"VALUES (NULL, '{bookNameSanitized}', {authorID}, {publisherID}, '{releaseDate}', {bookCategoryID}, '{bookDescriptionSanitized}', 0, 0, NULL)";

            int bookAddResult = DatabaseGateway.ExecuteNonQueryCommand(addNewBookSql, ref userSession.GetDatabaseConnectionRef());

            if (bookAddResult != 1)
            {
                return 4;
            }




            //success
            return 0;



        }
    
        public static void FillLendingsDataGrid(DataGridView dataGridView, ref UserSession userSession)
        {
            dataGridView.Rows.Clear();

            //getting lendings info from database
            string getLendingsSql = "SELECT lendings.lendingID, books.bookName, customers.firstName, customers.lastName, employees.firstName, employees.lastName, lendings.lendingDate, lendings.returnDate, lendings.finalReturnedDate, lendings.statusID FROM lendings, employees, books, customers WHERE employees.employeeID = lendings.employeeID AND customers.customerID = lendings.customerID AND books.bookID = lendings.bookID";
            string[,] lendingsSelectArray = DatabaseGateway.ExecuteSelectCommand(getLendingsSql, ref userSession.GetDatabaseConnectionRef());   

            if (lendingsSelectArray == null)
            {
                //error occured

            }
            else
            {
                //succedeed
                
                for (int i = 0; i < lendingsSelectArray.GetLength(0); i++)
                {
                    //DataGridViewRow row = new DataGridViewRow();
                    //row.CreateCells(dataGridView);
                    for (int j = 0; j < lendingsSelectArray.GetLength(1); j++)
                    {
                        //.Cells[j].Value = lendingsSelectArray[i, j];
                        
                    }
                    //dataGridView.Rows.Add(row);
                    
                }


            }
            
        }

    }
}


