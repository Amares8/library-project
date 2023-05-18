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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.DirectoryServices;
using System.Net;


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
            int lateReturnTest = DateTime.Compare(finalReturnedDateTime.Date, returnDateTime.Date);
            if (lateReturnTest  <= 0)
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

        public static int DeleteLending(ref UserSession userSession, int lendingID)
        {

            //fuinction first "returns" the book, to preserve correct stock quantities
            //then deletes the lending record from the base of the data
            /*
             * - FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters
             */

            int bookReturnResult = ReturnBook(ref userSession, lendingID, DateTime.Now.Date.ToString("yyyy-MM-dd"));

            if (bookReturnResult != 0 && bookReturnResult != 6)
            {
                //returning of a book failed
                return bookReturnResult;
            }

            //if returning successfull or previously done, delete record
            string deleteLendingRecordSql = $"DELETE FROM lendings WHERE `lendings`.`lendingID` = {lendingID}";
            int recordDeletingResult = DatabaseGateway.ExecuteNonQueryCommand(deleteLendingRecordSql, ref userSession.GetDatabaseConnectionRef());

            if (recordDeletingResult != 1)
            {
                //unknown error
                return 4;
            }

            //successfull
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
            
            if (releaseDate.Length < 10)
            {
                string temp = "";
                for (int  i = 0; i < 10 - releaseDate.Length; i++)
                {
                    temp += "0";
                }
                temp += releaseDate;
                releaseDate = temp;
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
            $"(`bookID`, `bookName`, `bookAuthorID`, `publisherID`, `releaseDate`, `bookCategoryID`, `bookDescription`, `quantityInStock`, `totalQuantityInStock`)" +
            $"VALUES (NULL, '{bookNameSanitized}', {authorID}, {publisherID}, '{releaseDate}', {bookCategoryID}, '{bookDescriptionSanitized}', 0, 0)";

            int bookAddResult = DatabaseGateway.ExecuteNonQueryCommand(addNewBookSql, ref userSession.GetDatabaseConnectionRef());

            if (bookAddResult != 1)
            {
                return 4;
            }




            //success
            return 0;



        }

        public static int DeleteBook(ref UserSession userSession, int bookID)
        {
            //fucntion that tries to delete book

            /*
             * - FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error (cannot be returned)
             * 5 - invalid/empty parameters
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
            if (userSession.GetPrivilege() < bookAddPrivilege)
            {
                //no privilege
                return 3;
            }


            string deleteBookRecordSql = $"DELETE FROM books WHERE bookID = {bookID}";
            int recordDeletingResult = DatabaseGateway.ExecuteNonQueryCommand(deleteBookRecordSql, ref userSession.GetDatabaseConnectionRef());

            if (recordDeletingResult != 1)
            {
                //unknown error
                return 4;
            }

            //successfull
            return 0;
        }

        public static int AddNewPublisher(ref UserSession userSession, string publisherName)
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
            if (publisherName == String.Empty)
            {
                //wrong parameters
                return 5;
            }
            if (userSession.GetPrivilege() < bookAddPrivilege)
            {
                //no privilege
                return 3;
            }


            string publisherNameSanitized = DatabaseGateway.SanitizeString(publisherName);

            string addNewPublisherSql = $"INSERT INTO `publishers` (`publisherID`, `name`) VALUES ('', '{publisherNameSanitized}');";


            int publisherAddResult = DatabaseGateway.ExecuteNonQueryCommand(addNewPublisherSql, ref userSession.GetDatabaseConnectionRef());

            if (publisherAddResult != 1)
            {
                return 4;
            }




            //success
            return 0;



        }

        public static int DeletePublisher(ref UserSession userSession, int publisherID)
        {
            //fucntion that tries to delete publisher

            /*
             * - FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error (cannot be returned)
             * 5 - invalid/empty parameters
             */

            if (!userSession.IsLoggedIn())
            {
                //not logged in
                return 1;
            }
            if (publisherID < 0)
            {
                //wrong parameters
                return 5;
            }
            if (userSession.GetPrivilege() < bookAddPrivilege)
            {
                //no privilege
                return 3;
            }


            string deletePublisherRecordSql = $"DELETE FROM publishers WHERE publisherID = {publisherID}";
            int recordDeletingResult = DatabaseGateway.ExecuteNonQueryCommand(deletePublisherRecordSql, ref userSession.GetDatabaseConnectionRef());

            if (recordDeletingResult != 1)
            {
                //unknown error
                return 4;
            }

            //successfull
            return 0;
        }

        public static int AddNewAuthor(ref UserSession userSession, string authorFirstName, string authorLastName, string authorName)
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
            if ((authorFirstName == String.Empty && authorLastName == String.Empty && authorName == String.Empty)
                || (authorName == String.Empty && (authorFirstName == String.Empty || authorLastName == String.Empty)))
            {
                //wrong parameters
                return 5;
            }
            if (userSession.GetPrivilege() < bookAddPrivilege)
            {
                //no privilege
                return 3;
            }


            string authorFirstNameSanitized = DatabaseGateway.SanitizeString(authorFirstName);
            string authorLastNameSanitized = DatabaseGateway.SanitizeString(authorLastName);
            string authorNameSanitized = DatabaseGateway.SanitizeString(authorName);

            

            string addNewAuthorSql = $"INSERT INTO `bookauthors` (`authorID`, `firstName`, `lastName`, `name`) VALUES ('', '{authorFirstNameSanitized}', '{authorLastNameSanitized}', '{authorNameSanitized}')";


            int authorAddResult = DatabaseGateway.ExecuteNonQueryCommand(addNewAuthorSql, ref userSession.GetDatabaseConnectionRef());

            if (authorAddResult != 1)
            {
                return 4;
            }




            //success
            return 0;



        }

        public static int DeleteAuthor(ref UserSession userSession, int authorID)
        {
            //fucntion that tries to delete publisher

            /*
             * - FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error (cannot be returned)
             * 5 - invalid/empty parameters
             */

            if (!userSession.IsLoggedIn())
            {
                //not logged in
                return 1;
            }
            if (authorID < 0)
            {
                //wrong parameters
                return 5;
            }
            if (userSession.GetPrivilege() < bookAddPrivilege)
            {
                //no privilege
                return 3;
            }


            string deleteAuthorRecordSql = $"DELETE FROM bookauthors WHERE authorID = {authorID}";
            int recordDeletingResult = DatabaseGateway.ExecuteNonQueryCommand(deleteAuthorRecordSql, ref userSession.GetDatabaseConnectionRef());

            if (recordDeletingResult != 1)
            {
                //unknown error
                return 4;
            }

            //successfull
            return 0;
        }


        public static int FillLendingsDataGrid(ref UserSession userSession, DataGridView dataGridView)
        {
            //funciotn tha fills dataGridView with lendings data
            //returns: 0 - success, 1 - error

            //Colours used to mark lendings with
            Color otherStatusColor = Color.FromArgb(204, 204, 204); // light gray
            Color lendedColor = Color.FromArgb(255, 255, 255); //white
            Color returnedColor = Color.FromArgb(245, 255, 245); // light green
            Color returnedLateColor = Color.FromArgb(248, 255, 229); // light yellow
            Color overdueColor = Color.FromArgb(255, 204, 204); // light red
            Color errorColor = Color.FromArgb(255, 0, 0); // red

            //clear all data form grid view
            dataGridView.Rows.Clear();

            //getting lendings info from database
            string getLendingsSql = "SELECT lendings.lendingID, books.bookName, bookauthors.firstName, bookauthors.lastName, bookauthors.name, customers.firstName, customers.lastName, employees.firstName, employees.lastName, DATE_FORMAT(lendings.lendingDate, '%d.%m.%Y'), DATE_FORMAT(lendings.returnDate, '%d.%m.%Y'), DATE_FORMAT(lendings.finalReturnedDate, '%d.%m.%Y'), lendings.statusID FROM bookauthors, lendings, employees, books, customers WHERE employees.employeeID = lendings.employeeID AND customers.customerID = lendings.customerID AND books.bookID = lendings.bookID AND books.bookAuthorID = bookauthors.authorID";
            string[,] lendingsSelectArray = DatabaseGateway.ExecuteSelectCommand(getLendingsSql, ref userSession.GetDatabaseConnectionRef());


            //check for error
            if (lendingsSelectArray == null)
            {
                return 1;
            }

            for (int i = 0; i < lendingsSelectArray.GetLength(0); i++)
            {
                //creatuing new data grid row

                /* Extended lending status column (9)
                 * is a hidden column for storing information about lending status taking into account
                 * if a ongoing lending is overdue or not
                 * 
                 * Unlike column lendingStatus(8) information is numerical, for programming usage
                 * Id's and their meaning:
                 * 
                 * 0 - other
                 * 1 - lended (not overdue)
                 * 2 - returned on time
                 * 3 - returned late
                 * 4 - lended and overdue
                 * 5 - error
                 * Any other values should be treated as errors :)
                 * 
                */

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);
                

                //assigning values to row cells
                row.Cells[0].Value = lendingsSelectArray[i, 0]; //lending id
                row.Cells[1].Value = lendingsSelectArray[i, 1]; //title
                if (lendingsSelectArray[i, 4] == "") //author
                    row.Cells[2].Value = lendingsSelectArray[i, 2] + " " + lendingsSelectArray[i, 3];
                else
                    row.Cells[2].Value = lendingsSelectArray[i, 4];
                row.Cells[3].Value = lendingsSelectArray[i, 5] + " " + lendingsSelectArray[i, 6]; //customer
                row.Cells[4].Value = lendingsSelectArray[i, 7] + " " + lendingsSelectArray[i, 8]; //employee
                row.Cells[5].Value = lendingsSelectArray[i, 9]; //date of lending
                row.Cells[6].Value = lendingsSelectArray[i, 10]; //return deadline
                row.Cells[7].Value = lendingsSelectArray[i, 11]; //date of book being returned


                switch (lendingsSelectArray[i, 12]) // lending status 
                {
                    case "0":
                        //other status
                        row.Cells[8].Value = "inny";
                        row.Cells[9].Value = "0"; //extended lending status
                        row.DefaultCellStyle.BackColor = otherStatusColor;
                        break;
                    case "1":
                        //lended

                        //checking if book is overdue
                        DateTime returnDateTime;
                        if (!DateTime.TryParse(row.Cells[6].Value.ToString(), out returnDateTime))
                        {
                            Debugger.CreateLogMessage("Błąd konwersji daty");
                            return 1;
                        }

                        int lateReturnTest = DateTime.Compare(DateTime.Now.Date, returnDateTime.Date);
                        if (lateReturnTest <= 0)
                        {
                            //not late
                            row.Cells[8].Value = "wypożyczona";
                            row.Cells[9].Value = "1"; //extended lending status
                            row.DefaultCellStyle.BackColor = lendedColor;
                        }
                        else
                        {
                            // is late
                            row.Cells[8].Value = "zaległa";
                            row.Cells[9].Value = "4"; //extended lending status
                            row.DefaultCellStyle.BackColor = overdueColor;
                        }
                        break;

                    case "2":
                        //returned
                        row.Cells[8].Value = "oddana";
                        row.Cells[9].Value = "2"; //extended lending status
                        row.DefaultCellStyle.BackColor = returnedColor;
                        break;

                    case "3":
                        //returned late
                        row.Cells[8].Value = "oddana po czasie";
                        row.Cells[9].Value = "3"; //extended lending status
                        row.DefaultCellStyle.BackColor = returnedLateColor;
                        break;

                    default:
                        //error
                        row.Cells[8].Value = "błąd";
                        row.Cells[9].Value = "5"; //extended lending status
                        row.DefaultCellStyle.BackColor = errorColor;
                        break;
                }



                //adding create row to dataGridViev passed in the parameter
                dataGridView.Rows.Add(row);

            }



            
            //retruning 0 as success code 
            return 0;

        }

        public static int FillBookSelectDataGrid(ref UserSession userSession, DataGridView dataGridView)
        {
            //funcion for getting all book list for book to choose lending
            string selectBooksSql = "SELECT books.bookId, books.bookName, bookauthors.firstName, bookauthors.lastName, bookauthors.name, publishers.name, DATE_FORMAT(books.releaseDate, '%Y'), books.quantityInStock FROM bookauthors, publishers, books WHERE books.bookAuthorID = bookauthors.authorID AND books.publisherID = publishers.publisherID";
            string[,] bookSelectList = DatabaseGateway.ExecuteSelectCommand(selectBooksSql, ref userSession.GetDatabaseConnectionRef());

            //check for error
            if (bookSelectList == null)
            {
                //error
                return 1;
            }



            //clear old data
            dataGridView.Rows.Clear();

            //0:id, 1:title, 2:author, 3:publisher, 4:releaseDate, 5:quantityInStock
            int rows = bookSelectList.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);

                row.Cells[0].Value = bookSelectList[i, 0]; //id
                row.Cells[1].Value = bookSelectList[i, 1]; //title
                if (bookSelectList[i, 4] == "") //author
                    row.Cells[2].Value = bookSelectList[i, 2] + " " + bookSelectList[i, 3];
                else
                    row.Cells[2].Value = bookSelectList[i, 4];
                row.Cells[3].Value = bookSelectList[i, 5]; // publisher
                row.Cells[4].Value = bookSelectList[i, 6]; // releaseDate
                row.Cells[5].Value = bookSelectList[i, 7]; //quantity in stock
                dataGridView.Rows.Add(row);
            }

            //returning success
            return 0;
        }


        public static int FillBooksDataGrid(ref UserSession userSession, DataGridView dataGridView)
        {
            //funciotn tha fills dataGridView with books data
            //returns: 0 - success, 1 - error

            //clear all data form grid view
            dataGridView.Rows.Clear();

            //getting lendings info from database
            string getBooksSql = "SELECT books.bookID, books.bookName, bookauthors.firstName, bookauthors.lastName, bookauthors.name, publishers.name, DATE_FORMAT(books.releaseDate, '%Y'), books.bookCategoryID, books.bookDescription, books.quantityInStock, books.totalQuantityInStock FROM bookauthors, books, publishers WHERE bookauthors.authorID = books.bookAuthorID AND publishers.publisherID = books.publisherID";
            string[,] booksSelectArray = DatabaseGateway.ExecuteSelectCommand(getBooksSql, ref userSession.GetDatabaseConnectionRef());


            //check for error
            if (booksSelectArray == null)
            {
                return 1;
            }

            for (int i = 0; i < booksSelectArray.GetLength(0); i++)
            {
                //creating new data grid row

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);


                //assigning values to row cells
                row.Cells[0].Value = booksSelectArray[i, 0]; //book id
                row.Cells[1].Value = booksSelectArray[i, 1]; //title
                if (booksSelectArray[i, 4] == "") //author
                    row.Cells[2].Value = booksSelectArray[i, 2] + " " + booksSelectArray[i, 3];
                else
                    row.Cells[2].Value = booksSelectArray[i, 4];
                row.Cells[3].Value = booksSelectArray[i, 5]; //publisher
                row.Cells[4].Value = booksSelectArray[i, 6]; //releaseDate
                switch (booksSelectArray[i, 7])
                {
                    case "0":
                        row.Cells[5].Value = "inny";
                        break;
                    case "1":
                        row.Cells[5].Value = "fantasy";
                        break;
                    case "2":
                        row.Cells[5].Value = "science-fiction";
                        break;
                    case "3":
                        row.Cells[5].Value = "horror";
                        break;
                    case "4":
                        row.Cells[5].Value = "kryminał";
                        break;
                    case "5":
                        row.Cells[5].Value = "klasyka";
                        break;
                    case "6":
                        row.Cells[5].Value = "sensacja";
                        break;
                    case "8":
                        row.Cells[5].Value = "romans";
                        break;
                    case "9":
                        row.Cells[5].Value = "nauka";
                        break;
                    case "10":
                        row.Cells[5].Value = "dla dzieci";
                        break;
                    case "11":
                        row.Cells[5].Value = "faktu";
                        break;
                    case "13":
                        row.Cells[5].Value = "powieść";
                        break;
                    default:
                        row.Cells[5].Value = "nieznany";
                        break;

                }//category
                row.Cells[6].Value = booksSelectArray[i, 8]; //description
                row.Cells[7].Value = booksSelectArray[i, 9] + " / " + booksSelectArray[i, 10]; //stock Level
                row.Cells[8].Value = booksSelectArray[i, 9]; // hidden available quantity
                row.Cells[9].Value = booksSelectArray[i, 10]; // hidden total stock level;

                //adding create row to dataGridViev passed in the parameter
                dataGridView.Rows.Add(row);

            }

            //retruning 0 as success code 
            return 0;

        }


        

        public static int FillAuthorsSelectDataGrid(ref UserSession userSession, DataGridView dataGridView)
        {
            //function for getting all authors list to select while adding new book
            // returns: 0 - success, 1 - error
            string selectClientSql = "SELECT authorID, firstName, lastName, name FROM bookauthors";
            string[,] clientSelectList = DatabaseGateway.ExecuteSelectCommand(selectClientSql, ref userSession.GetDatabaseConnectionRef());

            //check for error
            if (clientSelectList == null)
            {
                //error
                return 1;
            }


            //clear old data
            dataGridView.Rows.Clear();

            //fill grid with new data
            int rows = clientSelectList.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);

                row.Cells[0].Value = clientSelectList[i, 0]; //id
                if (clientSelectList[i, 3] == "") //author
                    row.Cells[1].Value = clientSelectList[i, 1] + " " + clientSelectList[i, 2];
                else
                    row.Cells[1].Value = clientSelectList[i, 3];

                dataGridView.Rows.Add(row);
            }

            //returning success
            return 0;
        }


        public static int FillPublishersSelectDataGrid(ref UserSession userSession, DataGridView dataGridView)
        {
            //function for getting all publishers list to select while adding new book
            // returns: 0 - success, 1 - error
            string selectPublishersSql = "SELECT publisherID, name FROM publishers";
            string[,] publishersSelectList = DatabaseGateway.ExecuteSelectCommand(selectPublishersSql, ref userSession.GetDatabaseConnectionRef());

            //check for error
            if (publishersSelectList == null)
            {
                //error
                return 1;
            }


            //clear old data
            dataGridView.Rows.Clear();

            //fill grid with new data
            int rows = publishersSelectList.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);

                row.Cells[0].Value = publishersSelectList[i, 0]; //id
                row.Cells[1].Value = publishersSelectList[i, 1]; //name
                

                dataGridView.Rows.Add(row);
            }

            //returning success
            return 0;
        }


        public static int FillCategoriesSelectDataGrid(ref UserSession userSession, DataGridView dataGridView)
        {
            //function for getting all categories / genres list to select while adding new book
            // returns: 0 - success, 1 - error
            string selectCategoriesSql = "SELECT id FROM bookCategories";
            string[,] categoriesSelectList = DatabaseGateway.ExecuteSelectCommand(selectCategoriesSql, ref userSession.GetDatabaseConnectionRef());

            //check for error
            if (categoriesSelectList == null)
            {
                //error
                return 1;
            }


            //clear old data
            dataGridView.Rows.Clear();

            //fill grid with new data
            int rows = categoriesSelectList.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);


                switch (categoriesSelectList[i, 0])
                {
                    case "0":
                        row.Cells[1].Value = "inny";
                        break;
                    case "1":
                        row.Cells[1].Value = "fantasy";
                        break;
                    case "2":
                        row.Cells[1].Value = "science-fiction";
                        break;
                    case "3":
                        row.Cells[1].Value = "horror";
                        break;
                    case "4":
                        row.Cells[1].Value = "kryminał";
                        break;
                    case "5":
                        row.Cells[1].Value = "klasyka";
                        break;
                    case "6":
                        row.Cells[1].Value = "sensacja";
                        break;
                    case "8":
                        row.Cells[1].Value = "romans";
                        break;
                    case "9":
                        row.Cells[1].Value = "nauka";
                        break;
                    case "10":
                        row.Cells[1].Value = "dla dzieci";
                        break;
                    case "11":
                        row.Cells[1].Value = "faktu";
                        break;
                    case "13":
                        row.Cells[1].Value = "powieść";
                        break;
                    default:
                        row.Cells[1].Value = "nieznany";
                        break;

                }//category
                row.Cells[0].Value = categoriesSelectList[i, 0]; //id
                


                dataGridView.Rows.Add(row);
            }

            //returning success
            return 0;
        }

        /*
        public static bool IsLendingReturnable(ref UserSession userSession, int lendingID)
        {

            if (!userSession.IsLoggedIn())
            {
                //not logged in
                return false;
            }
            if (lendingID < 0 || userSession.GetPrivilege() < bookLendPrivilege)
            {
                //no permissions
                Debugger.CreateLogMessage($"Brak uprawnien do infomracji o stanie wypozyecznia, uzytkownik {userSession.GetLogin()}");
                return false;
            }

            string checkReturnAbilitySql = $"SELECT statusID FROM lendings WHERE lendingID = {lendingID}";
            string lendingStatus = DatabaseGateway.ExecuteScalarCommand(checkReturnAbilitySql, ref userSession.GetDatabaseConnectionRef());

            
            if (lendingStatus == "1")
            {
                //valud to return
                return true;
            }

            //invalid for returning
            return false;
        }
        */


    }
}


