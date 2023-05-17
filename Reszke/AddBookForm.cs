using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Datatypes.Scalar.Types;

namespace Reszke
{
    public partial class AddBookForm : Form
    {

        UserSession userSession;
        public AddBookForm(ref UserSession userSession)
        {
            InitializeComponent();

            this.userSession = userSession;
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            LibraryManagement.FillAuthorsSelectDataGrid(ref userSession, authorSelectDataGridView);
            LibraryManagement.FillPublishersSelectDataGrid(ref userSession, publisherSelectDataGridView);
            LibraryManagement.FillCategoriesSelectDataGrid(ref userSession, categorySelectDataGridView);
            chooseYearUpDown.Value = DateTime.Now.Year;
            chooseYearUpDown.Maximum = DateTime.Now.Year;
        }

        private void authorSelectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (authorSelectDataGridView.CurrentRow != null)
            {
                DataGridViewRow selectedRow = authorSelectDataGridView.CurrentRow;

                string author = selectedRow.Cells[1].Value.ToString();
                if (author.Length > 30)
                {
                    author = string.Concat(author.Take(30));
                    author = author.Remove(author.Length - 4, 1).Insert(author.Length - 1, "...");

                }


                
                chosenAuthorLabel.Text = "Wybrano: " + author;
            }
        }

        private void publisherSelectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = publisherSelectDataGridView.CurrentRow;

            string publisher = selectedRow.Cells[1].Value.ToString();
            if (publisher.Length > 30)
            {
                publisher = string.Concat(publisher.Take(30));
                publisher = publisher.Remove(publisher.Length - 4, 1).Insert(publisher.Length - 1, "...");

            }




            chosenPublisherLabel.Text = "Wybrano: " + publisher;
        }

        private void categorySelectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = categorySelectDataGridView.CurrentRow;

            string category = selectedRow.Cells[1].Value.ToString();
            




            chosenCategoryLabel.Text = "Wybrano: " + category;
        }

        private void cancelBookAddButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmBookAddButton_Click(object sender, EventArgs e)
        {

             /*
             * - ADD BOOK FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters
             */

            int authorID = int.Parse(authorSelectDataGridView.CurrentRow.Cells[0].Value.ToString());
            int publisherID = int.Parse(publisherSelectDataGridView.CurrentRow.Cells[0].Value.ToString());
            int categoryID = int.Parse(categorySelectDataGridView.CurrentRow.Cells[0].Value.ToString());
            string releaseDate = chooseYearUpDown.Value.ToString() + "-01-01";


            int bookAddResult = LibraryManagement.AddNewBook(ref userSession, titleTextBox.Text, authorID, publisherID, releaseDate, categoryID, descriptionTextBox.Text);


            switch (bookAddResult)
            {
                case 0:
                    //success
                    bookAddErrorLabel.Text = string.Empty;
                    MessageBox.Show("Dodano nową książkę pomyślnie. ");
                    Close();
                    break;
                case 1:
                    //not logged in
                    bookAddErrorLabel.Text = "Użytkownik nie jest zalogowany. ";
                    break;
                case 3:
                    //no permissions
                    bookAddErrorLabel.Text = "Brak uprawnień do wykonania operacji. ";
                    break;
                case 4:
                    //sql/other mistake
                    bookAddErrorLabel.Text = "Wystąpił nieznany błąd. ";
                    break;
                case 5:
                    //uncorrect parameters
                    bookAddErrorLabel.Text = "Podano błędne parametry ";
                    break;
                default:
                    //unhandled exeption
                    bookAddErrorLabel.Text = "Wystapił nieobsłużony wyjątek. ";
                    break;

            }
        }
    }
}
