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
    public partial class AddClientForm : Form
    {
        UserSession userSession;
        public AddClientForm(ref UserSession userSession)
        {
            InitializeComponent();

            this.userSession = userSession;
        }

        private void cancelClientAddButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmClientAddButton_Click(object sender, EventArgs e)
        {

            /*
            * - ADD CLIENT FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - not logged in
            * 3 - no permissions
            * 4 - sql/other error
            * 5 - invalid/empty parameters
            */


            int clientAddResult = ClientManagement.RegisterClient(ref userSession, firstNameTextBox.Text, lastNameTextBox.Text, 
                telephoneTextBox.Text, postalCodeTextBox.Text, cityTextBox.Text, streetTextBox.Text,
                houseNumberTextBox.Text, apartmentNumberTextBox.Text, emailTextBox.Text);


            switch (clientAddResult)
            {
                case 0:
                    //success
                    newClientErrorLabel.Text = string.Empty;
                    MessageBox.Show("Dodano nowego klienta pomyślnie. ");
                    Close();
                    break;
                case 1:
                    //not logged in
                    newClientErrorLabel.Text = "Użytkownik nie jest zalogowany. ";
                    break;
                case 3:
                    //no permissions
                    newClientErrorLabel.Text = "Brak uprawnień do wykonania operacji. ";
                    break;
                case 4:
                    //sql/other mistake
                    newClientErrorLabel.Text = "Wystąpił nieznany błąd. ";
                    break;
                case 5:
                    //uncorrect parameters
                    newClientErrorLabel.Text = "Podano błędne parametry ";
                    break;
                default:
                    //unhandled exeption
                    newClientErrorLabel.Text = "Wystapił nieobsłużony wyjątek. ";
                    break;

            }
        }
    }
}
