using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Security;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            //temporary
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
                LibraryManagement.FillLendingsDataGrid(lendingsDataGridView, ref userSession);
            }
        }

        private void lendingsNavButton_Click(object sender, EventArgs e)
        {
            //switch panel to lendings
            lendingsPanel.Visible = true;

            //otherPanels.Visible = false;
        }
    }
}