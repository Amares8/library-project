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
    public partial class newLendingForm : Form
    {

        //reference to user session (and database connection)
        public UserSession userSession;

        public newLendingForm()
        {
            InitializeComponent();
        }

        private void newLendingForm_Load(object sender, EventArgs e)
        {
            //initialize form
            todayCheckbox_CheckedChanged(null, null);
            calculateReturnDateNumericUpDown_ValueChanged(null, null);

            //load data tp grid data views
            int bookFillResult = LibraryManagement.FillBookSelectDataGrid(ref userSession, bookSelectDataGridView);
            int clientFillResult = ClientManagement.FillClientSelectDataGrid(ref userSession, customerSelectDataGridView);
            
            if (bookFillResult == 1)
            {
                //error while loading book list
                newLendingErrorLabel.Text = "Błąd przy pobieraniu listy książek. ";
            }

            if (clientFillResult == 1)
            {
                //error while loading book list
                newLendingErrorLabel.Text = "Błąd przy pobieraniu listy klientów. ";
            }


        }

        private void cancelNewLendingButton_Click(object sender, EventArgs e)
        {
            //cancel, close form
            Close();
        }

        private void acceptNewLendingButton_Click(object sender, EventArgs e)
        {
            //try lending
            int bookID = int.Parse(bookSelectDataGridView.CurrentRow.Cells[0].Value.ToString());
            int customerID= int.Parse(customerSelectDataGridView.CurrentRow.Cells[0].Value.ToString());
            string lendingDate = lendingDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            string returnDate = returnDateTimePicker.Value.Date.ToString("yyyy-MM-dd");

            //lending
            int lendingResult = LibraryManagement.LendBook(ref userSession, bookID, customerID, lendingDate, returnDate);

            //error managing
            switch (lendingResult)
            {
                case 0:
                    //success
                    MessageBox.Show("Książka wypożyczona pomyślnie. ", "Pomyśle wypożyczenie");
                    Close();
                    break;
                case 1:
                    //not logged in
                    newLendingErrorLabel.Text = "Nie zalogowano. ";
                    break;
                case 2:
                    //insufficient stock
                    newLendingErrorLabel.Text = "Niewystarczająca ilość egzemplarzy książki na stanie. ";
                    break;
                case 3:
                    //no permissions
                    newLendingErrorLabel.Text = "Brak uprawnień do wypożyczenia ksiażki. ";
                    break;
                case 4:
                    //other error
                    newLendingErrorLabel.Text = "Wystąpił nieznany błąd. ";
                    break;
                case 5:
                    //data incorrect
                    newLendingErrorLabel.Text = "Podane dane są niepoprawne. ";
                    break;
                


            }

        }

        private void caluclateReturnDateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (caluclateReturnDateCheckbox.Checked)
            {
                //date calculating enabled

                //disable manual date picker
                returnDateTimePicker.Enabled = false;

                //enable days to add selector
                calculateReturnDateNumericUpDown.Enabled = true;

            }
            else
            {
                //date calculating disabled

                //enable manual date picker
                returnDateTimePicker.Enabled = true;

                //disable days to add selector
                calculateReturnDateNumericUpDown.Enabled = false;
            }

        }

        private void returnDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //datetike picked
            chosenReturnDateLabel.Text = "Wybrano: " + returnDateTimePicker.Value.ToString("dd.MM.yyyy");
        }

        private void calculateReturnDateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //calculate date
            returnDateTimePicker.Value = DateTime.Now.AddDays((double)calculateReturnDateNumericUpDown.Value);
        }

        private void lendingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //lending date picked

            //checking if later than today, if yes limit to today
            if (DateTime.Compare(DateTime.Now.Date, lendingDateTimePicker.Value.Date) < 1)
            {
                lendingDateTimePicker.Value = DateTime.Now.Date;
            }

            //writing in "Chosen: xx-xx-xxxx" label
            chosenLendingDateLabel.Text = "Wybrano " + lendingDateTimePicker.Value.ToString("dd.MM.yyyy");
        }

        private void todayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //today checkbox changed

            if (todayCheckbox.Checked)
            {
                //today enabled

                //disable manual date picker and overwrite the previously selected date with today
                lendingDateTimePicker.Enabled = false;
                lendingDateTimePicker.Value = DateTime.Now.Date;

            }
            else
            {
                //today disabled

                //enable manual date picker
                lendingDateTimePicker.Enabled = true;
                lendingDateTimePicker.Value = DateTime.Now.Date;
            }
        }

        private void bookSelectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //selected book to lend

            
            if (bookSelectDataGridView.CurrentRow != null)
            {
                DataGridViewRow selectedRow = bookSelectDataGridView.CurrentRow;

                string author = selectedRow.Cells[1].Value.ToString();
                string title = selectedRow.Cells[2].Value.ToString();
                string publisher = selectedRow.Cells[3].Value.ToString();
                string year = selectedRow.Cells[4].Value.ToString();
                //author - title (year, publisher)
                chosenBookLabel.Text = "Wybrano: " + title + " - " + author + " (" + publisher + ", " + year + ")";
            }
        }

        private void customerSelectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //selected customer to lend to

            if (customerSelectDataGridView.CurrentRow != null)
            {
                DataGridViewRow selectedRow = customerSelectDataGridView.CurrentRow;

                string firstName = selectedRow.Cells[1].Value.ToString();
                //name lastname
                chosenCustomerLabel.Text = "Wybrano: " + firstName;
            }
        }

        
    }
}
