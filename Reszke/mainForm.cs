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
            switch (((int)DateTime.Now.DayOfWeek))
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
            RefreshPublishersPanel();
        }

        private void authorsNavButton_Click(object sender, EventArgs e)
        {
            //switch panel to authors
            mainTabControl.SelectTab("authorsPage");
            currentTabLabel.Text = "Autorzy";
            RefreshAuthorsPanel();
        }

        /* ----------------------------------------------------------------------- */




        /* ------------------------------------------------------------------------ */
        /*                              Lendings panel                              */
        /* ------------------------------------------------------------------------ */


        private void RefreshLendingsPanel()
        {
            //when panel turned on
            LibraryManagement.FillLendingsDataGrid(ref userSession, lendingsDataGridView);
            
            //apply "lended" filter
            lendedFilterButton_Click(null, null);

            
            int firstVisibleIndex = getFirstVisibleRowIndex(lendingsDataGridView);
            if (firstVisibleIndex == -1)
            {
                deleteLendingButton.Enabled = false;
            }
            else
            {
                lendingsDataGridView.Rows[firstVisibleIndex].Selected = true;
                deleteLendingButton.Enabled = true;
            }
            
        }

        private int getFirstVisibleRowIndex(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Visible == true)
                {
                    return row.Index;
                }
            }
            return -1;
        }

        private void lendingsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Managing disabling and enabling returnLendingButton button
            DataGridViewRow selectedRow;
            try
            {
                 selectedRow = lendingsDataGridView.SelectedRows[0];
            }
            catch (Exception ex)
            {
                return;
            }
            
            
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
            int returnedBookID = int.Parse(lendingsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            string lendingDetails = String.Empty;
            lendingDetails += lendingsDataGridView.SelectedRows[0].Cells[2].Value.ToString() + " - "; // author
            lendingDetails += lendingsDataGridView.SelectedRows[0].Cells[1].Value.ToString() + "\n"; // title
            lendingDetails += lendingsDataGridView.SelectedRows[0].Cells[3].Value.ToString() + "\nz: "; // lending date
            lendingDetails += lendingsDataGridView.SelectedRows[0].Cells[5].Value.ToString() + "\ndo: "; // lending date
            lendingDetails += lendingsDataGridView.SelectedRows[0].Cells[6].Value.ToString();            //return date

            DateTime returnDateTime;
            DateTime finalReturnedDateTime;

            if (!DateTime.TryParse(lendingsDataGridView.SelectedRows[0].Cells[5].Value.ToString(), out returnDateTime))
            {
                Debugger.CreateLogMessage("Błąd konwersji daty przy próbie oddania książki");
                return;
            }

            if (!DateTime.TryParse(lendingsDataGridView.SelectedRows[0].Cells[6].Value.ToString(), out finalReturnedDateTime))
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
            int deleteLendingID = int.Parse(lendingsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            string lendingDetails = String.Empty;
            lendingDetails += lendingsDataGridView.SelectedRows[0].Cells[2].Value.ToString() + " - ";
            lendingDetails += lendingsDataGridView.SelectedRows[0].Cells[1].Value.ToString() + "\n";
            lendingDetails += lendingsDataGridView.SelectedRows[0].Cells[3].Value.ToString() + "\nz: ";
            lendingDetails += lendingsDataGridView.SelectedRows[0].Cells[5].Value.ToString() + "\ndo: ";
            lendingDetails += lendingsDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            DateTime finalReturnedDateTime;

            if (!DateTime.TryParse(lendingsDataGridView.SelectedRows[0].Cells[6].Value.ToString(), out finalReturnedDateTime))
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

            //auto select or disable delete and button
            int firstVisibleIndex = getFirstVisibleRowIndex(lendingsDataGridView);
            if (firstVisibleIndex == -1)
            {
                deleteLendingButton.Enabled = false;
            }
            else
            {
                lendingsDataGridView.Rows[firstVisibleIndex].Selected = true;
                deleteLendingButton.Enabled = true;
            }


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

            // auto select or disable delete button
            int firstVisibleIndex = getFirstVisibleRowIndex(lendingsDataGridView);
            if (firstVisibleIndex == -1)
            {
                deleteLendingButton.Enabled = false;
            }
            else
            {
                lendingsDataGridView.Rows[firstVisibleIndex].Selected = true;
                deleteLendingButton.Enabled = true;
            }

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

            // auto select or disable delete button
            int firstVisibleIndex = getFirstVisibleRowIndex(lendingsDataGridView);
            if (firstVisibleIndex == -1)
            {
                deleteLendingButton.Enabled = false;
            }
            else
            {
                lendingsDataGridView.Rows[firstVisibleIndex].Selected = true;
                deleteLendingButton.Enabled = true;
            }

            //lendingsDataGridView_SelectionChanged(null, null);
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


            // auto select or disable delete button
            int firstVisibleIndex = getFirstVisibleRowIndex(lendingsDataGridView);
            if (firstVisibleIndex == -1)
            {
                deleteLendingButton.Enabled = false;
            }
            else
            {
                lendingsDataGridView.Rows[firstVisibleIndex].Selected = true;
                deleteLendingButton.Enabled = true;
            }

           // lendingsDataGridView_SelectionChanged(null, null);
        }



        /* ------------------------------------------------------------------------------ */





        /* ------------------------------------------------------------------------ */
        /*                                Books panel                               */
        /* ------------------------------------------------------------------------ */


        private void RefreshBooksPanel()
        {
            //when panel turned on
            LibraryManagement.FillBooksDataGrid(ref userSession, booksDataGridView);

        }



        /* ----------------------- Books function buttons ------------------------ */
        private void changeBookQuantityButton_Click(object sender, EventArgs e)
        {
            //change book stock lvbel button click
            //open chnage quantity of book panel

            int bookID = int.Parse(booksDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            string bookDetails = String.Empty;
            int stockLevel = int.Parse(booksDataGridView.SelectedRows[0].Cells[8].Value.ToString());
            int totalStockLevel = int.Parse(booksDataGridView.SelectedRows[0].Cells[9].Value.ToString());

            bookDetails += booksDataGridView.SelectedRows[0].Cells[2].Value.ToString() + " - "; // author
            bookDetails += booksDataGridView.SelectedRows[0].Cells[1].Value.ToString() + "\n"; // title
            bookDetails += booksDataGridView.SelectedRows[0].Cells[3].Value.ToString() + ", ";//publisher
            bookDetails += booksDataGridView.SelectedRows[0].Cells[4].Value.ToString() + "\nStan: ";//year
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


        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            //delete book record button click
            int bookID = int.Parse(booksDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            string bookDetails = "";
            bookDetails += booksDataGridView.SelectedRows[0].Cells[2].Value.ToString() + " - ";
            bookDetails += booksDataGridView.SelectedRows[0].Cells[1].Value.ToString() + "\n(";
            bookDetails += booksDataGridView.SelectedRows[0].Cells[3].Value.ToString() + ", ";
            bookDetails += booksDataGridView.SelectedRows[0].Cells[4].Value.ToString() + ")";

            DeleteBookForm deleteBookForm = new DeleteBookForm(ref userSession, bookID, bookDetails);
            deleteBookForm.ShowDialog();
            RefreshBooksPanel();
        }
        /* ----------------------------------------------------------------------- */





        /* ------------------------------------------------------------------------ */
        /*                             Customers panel                              */
        /* ------------------------------------------------------------------------ */


        private void RefreshCustomersPanel()
        {
            //when panel turned on
            ClientManagement.FillCustomersDataGrid(ref userSession, customersDataGridView);
        }


        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm(ref userSession);
            addClientForm.ShowDialog();
            RefreshCustomersPanel();
        }

        private void modifyCustomerButton_Click(object sender, EventArgs e)
        {
            int clientID = int.Parse(customersDataGridView.SelectedRows[0].Cells[0].Value.ToString());


            string firstName = customersDataGridView.SelectedRows[0].Cells[10].Value.ToString();
            string lastName = customersDataGridView.SelectedRows[0].Cells[11].Value.ToString();
            string telephone = customersDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            string email = customersDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            string postalCode = customersDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            string city = customersDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            string street = customersDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            string houseNumber = customersDataGridView.SelectedRows[0].Cells[8].Value.ToString();
            string apartmentNumber = customersDataGridView.SelectedRows[0].Cells[9].Value.ToString();
            ModifyClientForm modifyClientForm = new ModifyClientForm(ref userSession, clientID, firstName, lastName, telephone,
                email, postalCode, city, street, houseNumber, apartmentNumber);
            modifyClientForm.ShowDialog();
            RefreshCustomersPanel();
        }


        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            //delete client record button click
            int bookID = int.Parse(customersDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            string clientDetails = "";
            clientDetails += customersDataGridView.SelectedRows[0].Cells[1].Value.ToString() + ", ";
            clientDetails += customersDataGridView.SelectedRows[0].Cells[2].Value.ToString() + "\n";
            clientDetails += customersDataGridView.SelectedRows[0].Cells[3].Value.ToString();


            CustomerDeleteForm customerDeleteForm = new CustomerDeleteForm(ref userSession, bookID, clientDetails);
            customerDeleteForm.ShowDialog();
            RefreshCustomersPanel();
        }

        /* ------------------------------------------------------------------------ */
        /*                             Employees panel                              */
        /* ------------------------------------------------------------------------ */

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(ref userSession);
            addEmployeeForm.ShowDialog();
            RefreshEmployeesPanel();
        }
        private void RefreshEmployeesPanel()
        {
            //when panel turned on
            UserManagement.FillEmployeesDataGrid(ref userSession, employeesDataGridView);

        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            //delete employee record button click
            int employeeID = int.Parse(employeesDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            string employeeDetails = "";
            employeeDetails += employeesDataGridView.SelectedRows[0].Cells[1].Value.ToString() + ", ";
            employeeDetails += employeesDataGridView.SelectedRows[0].Cells[2].Value.ToString() + "\n";
            employeeDetails += employeesDataGridView.SelectedRows[0].Cells[4].Value.ToString() + ", ";
            employeeDetails += employeesDataGridView.SelectedRows[0].Cells[3].Value.ToString();


            EmployeeDeleteForm employeeDeleteForm = new EmployeeDeleteForm(ref userSession, employeeID, employeeDetails);
            employeeDeleteForm.ShowDialog();
            RefreshEmployeesPanel();
        }

        /* ------------------------------------------------------------------------ */
        /*                            Publishers panel                              */
        /* ------------------------------------------------------------------------ */


        private void RefreshPublishersPanel()
        {
            //when panel turned on
            LibraryManagement.FillPublishersSelectDataGrid(ref userSession, publishersDataGridView);
            publishersErrorLabel.Text = string.Empty;

        }

        private void addPublisherButton_Click(object sender, EventArgs e)
        {
            /*
             * - PUBLISHER ADDING FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters

             */


            int publisherAddResult = LibraryManagement.AddNewPublisher(ref userSession, publisherNameTextBox.Text);

            switch (publisherAddResult)
            {
                case 0:
                    //success
                    publishersErrorLabel.Text = String.Empty;
                    publisherNameTextBox.Text = "";
                    MessageBox.Show("Pomyślnie dodano nowego wydawcę. ");
                    RefreshPublishersPanel();
                    break;
                case 1:
                    //success
                    publishersErrorLabel.Text = "Użytkownik nie jest zalogowany. ";
                    break;
                case 3:
                    //no pemissions
                    publishersErrorLabel.Text = "Brak uprawnień do wykonania operacji. ";
                    break;
                case 4:
                    //unknown erroro
                    publishersErrorLabel.Text = "Wystąpił nieznany błąd. ";
                    break;
                case 5:
                    //wrong parameters
                    publishersErrorLabel.Text = "Podano błędne parametry. ";
                    break;
                default:
                    //unhandled exeption
                    publishersErrorLabel.Text = "Wystąpił nieobsłużony wyjątek. ";
                    break;
            }
        }


        private void deletePublisherButton_Click(object sender, EventArgs e)
        {
            //delete
            int publisherID = int.Parse(publishersDataGridView.SelectedRows[0].Cells[0].Value.ToString());


            int publisherDeletingResult = LibraryManagement.DeletePublisher(ref userSession, publisherID);


            /*
            * - PUBLISHER DELETE FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - not logged in
            * 3 - no permissions
            * 4 - sql/other error (cannot be returned)
            * 5 - invalid/empty parameters
            */


            switch (publisherDeletingResult)
            {
                case 0:
                    //success
                    publishersDeleteErrorLabel.Text = "";
                    MessageBox.Show("Pomyślnie usunięto rekord wydawcy. ");
                    RefreshPublishersPanel();
                    break;
                case 1:
                    //not logged in
                    publishersDeleteErrorLabel.Text = "Użytkownik nie jest zalogowany. ";
                    break;
                case 3:
                    //no permissions
                    publishersDeleteErrorLabel.Text = "Brak uprawnień do wykonania operacji";
                    break;
                case 4:
                    //cannot delete
                    publishersDeleteErrorLabel.Text = "Wydawca nie mógł zostać usunięty. ";
                    break;
                case 5:
                    //wrong paramteretrs
                    publishersDeleteErrorLabel.Text = "Podano błędne parametry. ";
                    break;
                default:
                    //unbhandled
                    publishersDeleteErrorLabel.Text = "Wystąpił nieobsługiwany wyjątek. ";
                    break;

            }
        }

        /* ------------------------------------------------------------------------ */
        /*                              Authors panel                               */
        /* ------------------------------------------------------------------------ */

        private void RefreshAuthorsPanel()
        {
            //when panel turned on
            LibraryManagement.FillAuthorsSelectDataGrid(ref userSession, authorsDataGridView);
            authorsErrorLabel.Text = string.Empty;

        }

        private void firstLastNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (firstLastNameRadioButton.Checked)
            {
                //selected name and surname mode
                authorFirstNameTextBox.Enabled = true;
                authorLastNameTextBox.Enabled = true;

                authorNameTextBox.Enabled = false;
                authorNameTextBox.Text = "";
            }
            else
            {
                //selected only name mode
                authorFirstNameTextBox.Enabled = false;
                authorLastNameTextBox.Enabled = false;
                authorFirstNameTextBox.Text = "";
                authorLastNameTextBox.Text = "";

                authorNameTextBox.Enabled = true;
            }



        }


        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            /*
             * - FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters

             */

            int authorAddResult;

            if (firstLastNameRadioButton.Checked)
            {
                //name and suranme
                authorAddResult = LibraryManagement.AddNewAuthor(ref userSession, authorFirstNameTextBox.Text, authorLastNameTextBox.Text, "");

            }
            else
            {
                //only name
                authorAddResult = LibraryManagement.AddNewAuthor(ref userSession, "", "", authorNameTextBox.Text);
            }


            switch (authorAddResult)
            {
                case 0:
                    //success
                    authorsErrorLabel.Text = "";
                    MessageBox.Show("Dodano nowego autora pomyślnie. ");
                    RefreshAuthorsPanel();
                    break;
                case 1:
                    //not logged in
                    authorsErrorLabel.Text = "Użytkownik nie jest zalogowany. ";
                    break;
                case 3:
                    //not logged in
                    authorsErrorLabel.Text = "Brak uprawnień do wykonania operacji. ";
                    break;
                case 4:
                    //other error
                    authorsErrorLabel.Text = "Wystąpił nieznany błąd. ";
                    break;
                case 5:
                    //wrong parameters
                    authorsErrorLabel.Text = "Podano błędne parametry. ";
                    break;
                default:
                    //unhandled exception
                    authorsErrorLabel.Text = "Wystąpił nieobsługiwany wyjątek. ";
                    break;
            }

        }

        private void deleteAuthorButton_Click(object sender, EventArgs e)
        {
            //delete
            int authorID = int.Parse(authorsDataGridView.SelectedRows[0].Cells[0].Value.ToString());


            int authorDeletingResult = LibraryManagement.DeleteAuthor(ref userSession, authorID);


            /*
            * - AUTHOR DELETE FUNCTION RETURN VALUES -
            * 0 - successfull
            * 1 - not logged in
            * 3 - no permissions
            * 4 - sql/other error (cannot be returned)
            * 5 - invalid/empty parameters
            */


            switch (authorDeletingResult)
            {
                case 0:
                    //success
                    authorsDeleteErrorLabel.Text = "";
                    MessageBox.Show("Pomyślnie usunięto rekord autora. ");
                    RefreshAuthorsPanel();
                    break;
                case 1:
                    //not logged in
                    authorsDeleteErrorLabel.Text = "Użytkownik nie jest zalogowany. ";
                    break;
                case 3:
                    //no permissions
                    authorsDeleteErrorLabel.Text = "Brak uprawnień do wykonania operacji";
                    break;
                case 4:
                    //cannot delete
                    authorsDeleteErrorLabel.Text = "Klient nie mógł zostać usunięty. ";
                    break;
                case 5:
                    //wrong paramteretrs
                    authorsDeleteErrorLabel.Text = "Podano błędne parametry. ";
                    break;
                default:
                    //unbhandled
                    authorsDeleteErrorLabel.Text = "Wystąpił nieobsługiwany wyjątek. ";
                    break;
            }
        }

       
    }
}