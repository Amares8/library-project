using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reszke
{
    public partial class CustomerDeleteForm : Form
    {
        UserSession userSession;
        int customerID;
        string customerDetails;

        public CustomerDeleteForm(ref UserSession userSession, int customerID, string customerDetails)
        {
            InitializeComponent();
            this.userSession = userSession;
            this.customerID = customerID;
            this.customerDetails = customerDetails;
        }

        private void CustomerDeleteForm_Load(object sender, EventArgs e)
        {
            deleteRecordInfoLabel.Text = customerDetails;
        }

        private void cancelDeleteButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmDeleteButton_Click(object sender, EventArgs e)
        {

            //delete
            int customerDeletingResult = ClientManagement.DeleteClient(ref userSession, customerID);


            /*
            * - CUSTOMER DELETE FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - not logged in
            * 3 - no permissions
            * 4 - sql/other error (cannot be returned)
            * 5 - invalid/empty parameters
            */


            switch (customerDeletingResult)
            {
                case 0:
                    //success
                    deleteErrorLabel.Text = "";
                    MessageBox.Show("Pomyślnie usunięto rekord klienta. ");
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
                    deleteErrorLabel.Text = "Klient nie mógł zostać usunięty. ";
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
