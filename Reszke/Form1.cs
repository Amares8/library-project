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
        UserSession userSession;
        

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
            userSession.Login(login.Text, password.Text);
            loggedUserLabel.Text = "logged: " + userSession.GetFirstName() + " " + userSession.GetLastName();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            //int result = UserManagement.RegisterUser(ref userSession, "ogru", "Olaf", "Gruszkiewicz", "ogru@obi.org", 8, "Qwerty1@3", 2);
            //int result = UserManagement.DeleteUser(ref userSession, "ogru");
            //int result = UserManagement.ResetUsersPassword(ref userSession, "ogru");
            //int result = ClientManagement.RegisterClient(ref userSession, "Dawid", "Tylson", "668221323", "84-230", "Rumia", "Kosynierów", "3", "21", "dtylka@polki.pl");
            int result = ClientManagement.DeleteClient(ref userSession, 7);
            loggedUserLabel.Text = result.ToString();
        }
    }
}