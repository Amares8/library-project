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
    public partial class ModifyClientForm : Form
    {
        UserSession userSession;
        int clientID;
        string firstName;
        string lastName;
        string phoneNumber;
        string email;
        string postalCode;
        string city;
        string street;
        string houseNumber;
        string apartmentNumber;

        public ModifyClientForm(ref UserSession userSession, int clientID, string firstName, string lastName, string phoneNumber, string email, string postalCode, string city, string street, string houseNumber, string apartmentNumber)
        {
            InitializeComponent();
            this.userSession = userSession;
            this.clientID = clientID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.postalCode = postalCode;
            this.city = city;
            this.street = street;
            this.houseNumber = houseNumber;
            this.apartmentNumber = apartmentNumber;
        }

        private void ModifyClientForm_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            telephoneTextBox.Text = phoneNumber;
            emailTextBox.Text = email;
            postalCodeTextBox.Text = postalCode;
            cityTextBox.Text = city;
            streetTextBox.Text = street;
            houseNumberTextBox.Text = houseNumber;
            apartmentNumberTextBox.Text = apartmentNumber;
        }

        private void confirmModifyButton_Click(object sender, EventArgs e)
        {
            /*
            * - MODIFY EMPLOYEE FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - not logged in
            * 3 - no permissions
            * 4 - sql/other error
            * 5 - invalid/empty parameters
            */


            int clientModifyResult = ClientManagement.ModifyClient(ref userSession, clientID, firstNameTextBox.Text,
                lastNameTextBox.Text, telephoneTextBox.Text, postalCodeTextBox.Text, cityTextBox.Text,
                streetTextBox.Text, houseNumberTextBox.Text, apartmentNumberTextBox.Text, emailTextBox.Text);


            switch (clientModifyResult)
            {
                case 0:
                    //success
                    errorLabel.Text = string.Empty;
                    MessageBox.Show("Zmieniono dane klienta pomyślnie. ");
                    Close();
                    break;
                case 1:
                    //not logged in
                    errorLabel.Text = "Użytkownik nie jest zalogowany. ";
                    break;
                case 3:
                    //no permissions
                    errorLabel.Text = "Brak uprawnień do wykonania operacji. ";
                    break;
                case 4:
                    //sql/other mistake
                    errorLabel.Text = "Wystąpił nieznany błąd. ";
                    break;
                case 5:
                    //uncorrect parameters
                    errorLabel.Text = "Podano błędne parametry ";
                    break;
                default:
                    //unhandled exeption
                    errorLabel.Text = "Wystapił nieobsłużony wyjątek. ";
                    break;

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
