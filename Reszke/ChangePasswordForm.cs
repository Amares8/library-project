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
    public partial class ChangePasswordForm : Form
    {

        UserSession userSession;

        public ChangePasswordForm(ref UserSession userSession)
        {
            InitializeComponent();
            this.userSession = userSession;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            userLabel.Text = "Użytkownik: " + userSession.GetFirstName() + " " + userSession.GetLastName();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (newPassword1TextBox.Text != newPassword2TextBox.Text)
            {
                errorLabel.Text = "Hasła nie są takie same. ";
                return;
            }

            //delete
            int result = userSession.ChangePassword(oldPasswordTextBox.Text, newPassword1TextBox.Text);



            /*
            * - FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - not logged in
            * 2 - wrong password
            * 4 - sql/other error
            * 5 - invalid/empty parameters
            */


            switch (result)
            {
                case 0:
                    //success
                    errorLabel.Text = "";
                    MessageBox.Show("Pomyślnie zmieniono hasło. ");
                    Close();
                    break;
                case 1:
                    //not logged in
                    errorLabel.Text = "Użytkownik nie jest zalogowany. ";
                    break;
                case 2:
                    //success
                    errorLabel.Text = "podano błędne hasło. ";
                    break;
                case 4:
                    //success
                    errorLabel.Text = "Wystąpił nieznany błąd. ";
                    break;
                case 5:
                    //success
                    errorLabel.Text = "Podano błędne parametry. ";
                    break;
                default:
                    //unbhandled
                    errorLabel.Text = "Wystąpił nieobsługiwany wyjątek. ";
                    break;

            }
        }
    }
}
