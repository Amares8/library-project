using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reszke
{
    public partial class DeleteBookForm : Form
    {
        UserSession userSession;
        int bookID;
        string bookDetails;

        public DeleteBookForm(ref UserSession userSession, int bookID, string bookDetails)
        {
            InitializeComponent();
            this.userSession= userSession;
            this.bookID = bookID;
            this.bookDetails = bookDetails;
        }

        private void DeleteBookForm_Load(object sender, EventArgs e)
        {
            deleteRecordInfoLabel.Text = bookDetails;
        }

        private void cancelDeleteButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmDeleteButton_Click(object sender, EventArgs e)
        {

            //delete
            int bookDeletingResult = LibraryManagement.DeleteBook(ref userSession, bookID);


            /*
            * - BOOK DELETE FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - not logged in
            * 3 - no permissions
            * 4 - sql/other error (cannot be returned)
            * 5 - invalid/empty parameters
            */


            switch (bookDeletingResult)
            {
                case 0:
                    //success
                    deleteErrorLabel.Text = "";
                    MessageBox.Show("Pomyślnie usunięto rekord książki. ");
                    Close();
                    break;
                case 1:
                    //not logged in
                    deleteErrorLabel.Text = "Użytkownik nie jest zalogowany. ";
                    break;
                case 3:
                    //success
                    deleteErrorLabel.Text = "Brak uprawnień do wykonania operacji";
                    break;
                case 4:
                    //success
                    deleteErrorLabel.Text = "Książka nie mogła zostać usunięta. ";
                    break;
                case 5:
                    //success
                    deleteErrorLabel.Text = "Podano błędne parametry. ";
                    break;
                default:
                    //unbhandled
                    deleteErrorLabel.Text = "Wystąpił nieobsługiwany wyjątek. ";
                    break;

            }
        }
    }
}
