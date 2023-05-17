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


            //setting the mainTabControl to hide the tab selector from user
            mainTabControl.Appearance = TabAppearance.FlatButtons;
            mainTabControl.ItemSize = new Size(0, 1);
            mainTabControl.SizeMode = TabSizeMode.Fixed;

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


        /* ------------------------------ Login page ------------------------------ */

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

                    lendingsNavButton_Click(null, null);
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

        /* ------------------------------------------------------------------------- */



        /* --------------------- Navigation panel buttons ------------------------ */

        private void lendingsNavButton_Click(object sender, EventArgs e)
        {
            //switch panel to lendings
            mainTabControl.SelectTab("lendingsPage");
            currentTabLabel.Text = "Wypożyczenia";
            RefreshLendingsPanel();
        }

        private void booksNavButton_Click(object sender, EventArgs e)
        {
            //switch panel to books
            mainTabControl.SelectTab("booksPage");
            currentTabLabel.Text = "Książki";
            RefreshBooksPanel();
        }


        private void customersNavButton_Click(object sender, EventArgs e)
        {
            //switch panel to customers
            mainTabControl.SelectTab("customersPage");
            currentTabLabel.Text = "Klienci";
            RefreshCustomersPanel();
        }

        private void employeesNavButton_Click(object sender, EventArgs e)
        {
            //switch panel to emplyees
            mainTabControl.SelectTab("employeesPage");
            currentTabLabel.Text = "Pracownicy";
            RefreshEmployeesPanel();
        }

        private void statisticsNavButton_Click(object sender, EventArgs e)
        {
            //switch panel to statistics
            mainTabControl.SelectTab("statisticsPage");
            currentTabLabel.Text = "Statystyki";
        }

        private void publishersNavButton_Click(object sender, EventArgs e)
        {
            //switch panel to publishers
            mainTabControl.SelectTab("publishersPage");
            currentTabLabel.Text = "Wydawcy";
        }

        private void authorsNavButton_Click(object sender, EventArgs e)
        {
            //switch panel to authors
            mainTabControl.SelectTab("authorsPage");
            currentTabLabel.Text = "Autorzy";
        }

        /* ----------------------------------------------------------------------- */


        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }


        /* ------------------------------------------------------------------------ */
        /*                              Lendings panel                              */
        /* ------------------------------------------------------------------------ */


        private void RefreshLendingsPanel()
        {
            //when panel turned on
            LibraryManagement.FillLendingsDataGrid(ref userSession, lendingsDataGridView);
            //apply "all" filter
            allFilterButton_Click(null, null);
        }

        private void lendingsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Managing disabling and enabling returnLendingButton button
            DataGridViewRow selectedRow = lendingsDataGridView.CurrentRow;
            bool isReturnable = false;
            if (selectedRow != null)
            { 
                if (selectedRow.Cells[9].Value.ToString() == "1" || selectedRow.Cells[9].Value.ToString() == "4")
                {
                    //is returnable
                    isReturnable = true;
                }
                
            }
            returnLendingButton.Enabled = isReturnable;
        }




        /* ----------------------- Lendings function buttons ------------------------ */
        private void newLendingButton_Click(object sender, EventArgs e)
        {
            //open new lending panel
            newLendingForm addLendingForm = new newLendingForm();
            addLendingForm.userSession = userSession;

            addLendingForm.ShowDialog();
            //refresh datagridview
            RefreshLendingsPanel();

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
            RefreshLendingsPanel();

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
            RefreshLendingsPanel();

        }

        /* ------------------------------------------------------------------------- */



        /* ---------------------- Lendings datagridview filters ------------------------ */

        private void lendedFilterButton_Click(object sender, EventArgs e)
        {
            //filter only lended (and overdue books)

            foreach (DataGridViewRow row in lendingsDataGridView.Rows)
            {
                if (row.Cells[9].Value.ToString() != "1" && row.Cells[9].Value.ToString() != "4")
                {
                    //if not lended, hide
                    row.Visible = false;
                }
                else
                {
                    //ptherwise are lended, show
                    row.Visible = true;
                }
            }

            //disable button
            lendedFilterButton.Enabled = false;

            //enable other buttons
            overdueFilterButton.Enabled = true;
            returnedFilterButton.Enabled = true;
            allFilterButton.Enabled = true;


        }

        private void overdueFilterButton_Click(object sender, EventArgs e)
        {
            //filter only lended (and overdue books)

            foreach (DataGridViewRow row in lendingsDataGridView.Rows)
            {
                if (row.Cells[9].Value.ToString() != "4")
                {
                    //if not lended, hide
                    row.Visible = false;
                }
                else
                {
                    //ptherwise are lended, show
                    row.Visible = true;
                }
            }

            //disable button
            overdueFilterButton.Enabled = false;

            //enable other buttons
            lendedFilterButton.Enabled = true;
            returnedFilterButton.Enabled = true;
            allFilterButton.Enabled = true;
        }

        private void returnedFilterButton_Click(object sender, EventArgs e)
        {
            //filter only lended (and overdue books)

            foreach (DataGridViewRow row in lendingsDataGridView.Rows)
            {
                if (row.Cells[9].Value.ToString() != "2" && row.Cells[9].Value.ToString() != "3")
                {
                    //if not lended, hide
                    row.Visible = false;
                }
                else
                {
                    //ptherwise are lended, show
                    row.Visible = true;
                }
            }

            //disable button
            returnedFilterButton.Enabled = false;

            //enable other buttons
            lendedFilterButton.Enabled = true;
            overdueFilterButton.Enabled = true;
            allFilterButton.Enabled = true;
        }

        private void allFilterButton_Click(object sender, EventArgs e)
        {
            //filter only lended (and overdue books)

            foreach (DataGridViewRow row in lendingsDataGridView.Rows)
            {
                row.Visible = true;
            }

            //disable button
            allFilterButton.Enabled = false;
            

            //enable other buttons
            lendedFilterButton.Enabled = true;
            overdueFilterButton.Enabled = true;
            returnedFilterButton.Enabled = true;

        }



        /* ------------------------------------------------------------------------------ */





        /* ------------------------------------------------------------------------ */
        /*                                Books panel                               */
        /* ------------------------------------------------------------------------ */


        private void RefreshBooksPanel()
        {
            //when panel turned on
            LibraryManagement.FillBooksDataGrid(ref userSession, booksDataGridView);
            //apply "all" filter
            //allFilterButton_Click(null, null);
        }



        /* ----------------------- Books function buttons ------------------------ */
        private void changeBookQuantityButton_Click(object sender, EventArgs e)
        {
            //change book stock lvbel button click
            //open chnage quantity of book panel

            int bookID = int.Parse(booksDataGridView.CurrentRow.Cells[0].Value.ToString());
            string bookDetails = String.Empty;
            int stockLevel = int.Parse(booksDataGridView.CurrentRow.Cells[8].Value.ToString());
            int totalStockLevel = int.Parse(booksDataGridView.CurrentRow.Cells[9].Value.ToString());

            bookDetails += booksDataGridView.CurrentRow.Cells[2].Value.ToString() + " - "; // author
            bookDetails += booksDataGridView.CurrentRow.Cells[1].Value.ToString() + "\n"; // title
            bookDetails += booksDataGridView.CurrentRow.Cells[3].Value.ToString() + ", ";//publisher
            bookDetails += booksDataGridView.CurrentRow.Cells[4].Value.ToString() + "\nStan: ";//year
            bookDetails += stockLevel + " / ";//stock level
            bookDetails += totalStockLevel;//total stock level

            //create now form
            ChangeBookQuantityForm changeBookQuantityForm = new ChangeBookQuantityForm(ref userSession, bookID, bookDetails, stockLevel, totalStockLevel);
            changeBookQuantityForm.ShowDialog();
            //refresh datagridview
            RefreshBooksPanel();
        }

        private void addNewBookButton_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(ref userSession);
            addBookForm.ShowDialog();
            RefreshBooksPanel();
        }

        /* ----------------------------------------------------------------------- */


        /* ------------------------------------------------------------------------ */
        /*                             Customers panel                              */
        /* ------------------------------------------------------------------------ */


        private void RefreshCustomersPanel()
        {
            //when panel turned on
            LibraryManagement.FillCustomersDataGrid(ref userSession, customersDataGridView);
            //apply "all" filter
            //allFilterButton_Click(null, null);
        }



        /* ------------------------------------------------------------------------ */
        /*                             Employees panel                              */
        /* ------------------------------------------------------------------------ */

        private void RefreshEmployeesPanel()
        {
            //when panel turned on
            LibraryManagement.FillCustomersDataGrid(ref userSession, employeesDataGridView);

        }


    }
}