using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Security;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Reszke
{
    public partial class mainForm : Form
    {
        //używany w aplikacji pakiet językowy
        LanguagePack currentLanguage;
        public UserSession userSession;
        

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Załadowanie pakietu językowego
            currentLanguage = ConfigFileLoader.LoadLanguagePack("lang/polish.json");

            //Utworzenie sesji uzytkonika
            MySqlConnection mySqlConnection = new MySqlConnection(ConfigFileLoader.LoadDBConnectionString("dbConfig.json"));
            userSession = new UserSession(ref mySqlConnection);

            

        }



        private void navTimeTimer_Tick(object sender, EventArgs e)
        {
            string navTimeLabelText = string.Empty;
            switch(((int)DateTime.Now.DayOfWeek))
            {
                case 0:
                    navTimeLabelText += currentLanguage.sunday;
                    break;
                case 1:
                    navTimeLabelText += currentLanguage.monday;
                    break;
                case 2:
                    navTimeLabelText += currentLanguage.tuesday;
                    break;
                case 3:
                    navTimeLabelText += currentLanguage.wednesday;
                    break;
                case 4:
                    navTimeLabelText += currentLanguage.thursday;
                    break;
                case 5:
                    navTimeLabelText += currentLanguage.friday;
                    break;
                case 6:
                    navTimeLabelText += currentLanguage.saturday;
                    break;
                
            }

            navTimeLabelText += "\n" + DateTime.Now.ToString("dd.MM.yyyy");
            navTimeLabelText += "\n" + DateTime.Now.ToString("HH:mm:ss");
            navTimeLabel.Text = navTimeLabelText;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //temporary !!!
            loginTextBox.Text = "amares8";
            passwordTextBox.Text = "Qwerty1@3";


            //logging in
            int userLoginResult = userSession.Login(loginTextBox.Text, passwordTextBox.Text);
            passwordTextBox.Text = string.Empty;

            switch (userLoginResult)
            {
                case 0:
                    //login successfull
                    loginErrorLabel.Text = string.Empty;
          
                    lendingsPanel.Show();
                    navButtonsPanel.Show();
                    currentUserLabel.Text = userSession.GetFirstName() + " " + userSession.GetLastName();

                    loginPanel.Hide();
                    break;
                case 1:
                    //already logged in
                    loginErrorLabel.Text = "Użytkownik jest już zalogowany. ";
                    break;
                case 2:
                    //wrong login
                    loginErrorLabel.Text = "Podano błędny login. ";
                    break;
                case 3:
                    //wrong password
                    loginErrorLabel.Text = "Podano błędne hasło. ";
                    break;
                case 4:
                    //other error
                    loginErrorLabel.Text = "Wystapił nieznany błąd. ";
                    break;
                case 5:
                    //empty login
                    loginErrorLabel.Text = "Login nie może być pusty. ";
                    break;
                case 6:
                    //empty password
                    loginErrorLabel.Text = "Hasło nie może być puste. ";
                    break;

            }

            

        }

        private void lendingsPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (lendingsPanel.Visible)
            {
                //when panel turned on
                LibraryManagement.FillLendingsDataGrid(ref userSession, lendingsDataGridView);
            }
        }

        private void lendingsNavButton_Click(object sender, EventArgs e)
        {
            //switch panel to lendings
            lendingsPanel.Visible = true;
            //refreshPanel
            lendingsPanel_VisibleChanged(sender, e);

            //otherPanels.Visible = false;
        }

        private void newLendingButton_Click(object sender, EventArgs e)
        {
            //open new lending panel
            newLendingForm addLendingForm = new newLendingForm();
            addLendingForm.userSession = userSession;

            addLendingForm.ShowDialog();
            //refresh datagridview
            lendingsPanel_VisibleChanged(null, null);

        }

        private void lendingsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Managing disabling and enabling returnLendingButton button
            DataGridViewRow selectedRow = lendingsDataGridView.CurrentRow;
            bool isReturnable = false;
            if (selectedRow.Cells[9].Value.ToString() == "1" || selectedRow.Cells[9].Value.ToString() == "4")
            {
                //is returnable
                isReturnable = true;
            }
            returnLendingButton.Enabled = isReturnable;

        }

        private void returnLendingButton_Click(object sender, EventArgs e)
        {
            //return book button click
            //open return book panel
            int returnedBookID = int.Parse(lendingsDataGridView.CurrentRow.Cells[0].Value.ToString());
            string lendingDetails = String.Empty;
            lendingDetails += lendingsDataGridView.CurrentRow.Cells[2].Value.ToString() + " - "; // author
            lendingDetails += lendingsDataGridView.CurrentRow.Cells[1].Value.ToString() + "\n"; // title
            lendingDetails += lendingsDataGridView.CurrentRow.Cells[3].Value.ToString() + "\nz: "; // lending date
            lendingDetails += lendingsDataGridView.CurrentRow.Cells[5].Value.ToString() + "\ndo: "; // lending date
            lendingDetails += lendingsDataGridView.CurrentRow.Cells[6].Value.ToString();            //return date

            DateTime returnDateTime;
            DateTime finalReturnedDateTime;

            if (!DateTime.TryParse(lendingsDataGridView.CurrentRow.Cells[5].Value.ToString(), out returnDateTime))
            {
                Debugger.CreateLogMessage("Błąd konwersji daty przy próbie oddania książki");
                return;
            }

            if (!DateTime.TryParse(lendingsDataGridView.CurrentRow.Cells[6].Value.ToString(), out finalReturnedDateTime))
            {
                Debugger.CreateLogMessage("Błąd konwersji daty przy próbie oddania książki");
                return;
            }

            //create now form
            ReturnLendingForm returnLendingForm = new ReturnLendingForm(ref userSession, returnedBookID, lendingDetails, returnDateTime, finalReturnedDateTime);
            returnLendingForm.ShowDialog();
            //refresh datagridview
            lendingsPanel_VisibleChanged(null, null);

        }

        private void deleteLendingButton_Click(object sender, EventArgs e)
        {
            //delete lending record button click
            int deleteLendingID = int.Parse(lendingsDataGridView.CurrentRow.Cells[0].Value.ToString());
            string lendingDetails = String.Empty;
            lendingDetails += lendingsDataGridView.CurrentRow.Cells[2].Value.ToString() + " - ";
            lendingDetails += lendingsDataGridView.CurrentRow.Cells[1].Value.ToString() + "\n";
            lendingDetails += lendingsDataGridView.CurrentRow.Cells[3].Value.ToString() + "\nz: ";
            lendingDetails += lendingsDataGridView.CurrentRow.Cells[5].Value.ToString() + "\ndo: ";
            lendingDetails += lendingsDataGridView.CurrentRow.Cells[6].Value.ToString();
            DateTime finalReturnedDateTime;

            if (!DateTime.TryParse(lendingsDataGridView.CurrentRow.Cells[6].Value.ToString(), out finalReturnedDateTime))
            {
                Debugger.CreateLogMessage("Błąd konwersji daty przy próbie usunięcia rekordu wypożyczenia");
                return;
            }

            //create now form
            DeleteLendingForm deleteLendingForm = new DeleteLendingForm(ref userSession, deleteLendingID, lendingDetails);
            deleteLendingForm.ShowDialog();


            //refresh datagridview
            lendingsPanel_VisibleChanged(null, null);

        }
    }
}