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
    public partial class DeleteLendingForm : Form
    {
        UserSession userSession;
        int lendingID;
        string lendingInfo;

        public DeleteLendingForm(ref UserSession userSession, int lendingID, string lendingInfo)
        {
            InitializeComponent();
            this.userSession = userSession;
            this.lendingID = lendingID;
            this.lendingInfo = lendingInfo;
        }

        private void DeleteLendingForm_Load(object sender, EventArgs e)
        {
            deleteRecordInfoLabel.Text = lendingInfo;
        }

        private void cancelDeleteButton_Click(object sender, EventArgs e)
        {
            //cancel and exit
            Close();
        }

        private void confirmDeleteButton_Click(object sender, EventArgs e)
        {
            //delete record
            /*
            * - DeleteLending RETURN VALUES -
            * 0 - successfull
            * 1 - not logged in
            * 3 - no permissions
            * 4 - sql/other error
            * 5 - invalid/empty parameters
            */


            int recordDeletingResult = LibraryManagement.DeleteLending(ref userSession, lendingID);

            switch (recordDeletingResult)
            {
                case 0:
                    //success
                    MessageBox.Show("Rekord wypożyczenia usunięty pomyślnie. ", "Usuwanie pomyślne");
                    Close();
                    break;
                case 1:
                    errorLabel.Text = "Użytkownik nie jest zalogowany. ";
                    break;
                case 3:
                    errorLabel.Text = "Brak uprawnień do wykonania operacji. ";
                    break;
                case 4:
                    errorLabel.Text = "Wystąpił nieznany błąd. ";
                    break;
                case 5:
                    errorLabel.Text = "Wprowadzono nieprawidłowe parametry. ";
                    break;
                default:
                    errorLabel.Text = "Wystąpił nieobsłużony wyjątek. ";
                    break;
            }

           
        }

        
    }
}
