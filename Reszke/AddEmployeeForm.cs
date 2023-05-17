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
    public partial class AddEmployeeForm : Form
    {
        UserSession userSession;
        public AddEmployeeForm(ref UserSession userSession)
        {
            InitializeComponent();

            this.userSession = userSession;
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            privilegeUpDown.Maximum = userSession.GetPrivilege();
        }


        private void confirmAddButton_Click(object sender, EventArgs e)
        {
            /*
            * - ADD EMPLOYEE FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - not logged in
            * 3 - no permissions
            * 4 - sql/other error
            * 5 - invalid/empty parameters
            */


            int employeeAddResult = UserManagement.RegisterUser(ref userSession, loginTextBox.Text, firstNameTextBox.Text,
                                lastNameTextBox.Text, emailTextBox.Text, jobTitleComboBox.SelectedIndex, UserManagement.GetDefaultPassword(),
                                (int)privilegeUpDown.Value);


            switch (employeeAddResult)
            {
                case 0:
                    //success
                    errorLabel.Text = string.Empty;
                    MessageBox.Show("Dodano nowego pracownika pomyślnie. ");
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

        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
