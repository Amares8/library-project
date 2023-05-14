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
    public partial class ReturnLendingForm : Form
    {
        //user session
        public UserSession userSession;
        int lendingID;
        string returnedBookInfo;
        DateTime lendingDate;
        DateTime returnDate;

        public ReturnLendingForm(ref UserSession userSession, int lendingID, string returnedBookInfo, DateTime lendingDate, DateTime returnDate)
        {
            InitializeComponent();
            this.userSession = userSession;
            this.lendingID = lendingID;
            this.returnedBookInfo = returnedBookInfo;
            this.returnDate = returnDate;
            this.lendingDate= lendingDate;
        }

        private void ReturnLendingForm_Load(object sender, EventArgs e)
        {
            //limiting the final returned date to max today
            finalReturnedDateTimePicker.MaxDate = DateTime.Now.Date;

            //info about the returning book
            lendingInfoDetailsLabel.Text = returnedBookInfo;

            //setting the default chosen date to today
            finalReturnedDateTimePicker.Value = DateTime.Now.Date;
            finalChosenReturnedDateLabel.Text = "Wybrano: " + DateTime.Now.Date.ToString("dd.MM.yyyy");

            //setting minimal date as date of lending (book cannot be returned earlier than borrowed)
            finalReturnedDateTimePicker.MinDate = lendingDate.Date;
            



        }

        private void cancelReturningButton_Click(object sender, EventArgs e)
        {
            //cancel eturning
            Close();
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            //return book
            int bookReturnResult = LibraryManagement.ReturnBook(ref userSession, lendingID, finalReturnedDateTimePicker.Value.ToString("yyyy-MM-dd"));
            
            switch (bookReturnResult)
            {
                case 0:
                    //success
                    MessageBox.Show("Udało się wprowadzić zwrot książki do systemu. ", "Zwrot udany");
                    break;
                case 1:
                    bookReturnErrorLabel.Text = "Nie zalogowano. ";
                    break;
                case 3:
                    bookReturnErrorLabel.Text = "Brak uprawnień do zwrotu książki. ";
                    break;
                case 4:
                    bookReturnErrorLabel.Text = "Wystąpił nieznany błąd. ";
                    break;
                case 5:
                    bookReturnErrorLabel.Text = "Podano błędne parametry. ";
                    break;
                case 6:
                    bookReturnErrorLabel.Text = "Książka nie może zostać zwrócona. ";
                    break;
                default:
                    bookReturnErrorLabel.Text = "Wystąpił nieobsłużony wyjątek. ";
                    break;


            }


            /*
             * - BOOK RETURN FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters
             * 6 - book already returned / invalid status
             */

            Close();

        }

        private void todayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //today
            if (todayCheckBox.Checked)
            {
                //today enabled
                finalReturnedDateTimePicker.Enabled = false;
                finalReturnedDateTimePicker.Value = DateTime.Now.Date;
            }
            else
            {
                //manual date
                finalReturnedDateTimePicker.Enabled = true;
            }
        }

        private void finalReturnedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            //finalReturnDate changed

            //assigning "chosen: " label
            finalChosenReturnedDateLabel.Text = "Wybrano: " + finalReturnedDateTimePicker.Value.ToString("dd.MM.yyyy");

            int daysLate = (finalReturnedDateTimePicker.Value - returnDate.Date).Days;
            if (daysLate < 0)
            {
                daysLate = 0;
            }

            //assigning overdue value
            overdueInfoLabel.Text = "Dni: " + daysLate;
        }
    }
}
