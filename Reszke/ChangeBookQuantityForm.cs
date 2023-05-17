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
    public partial class ChangeBookQuantityForm : Form
    {

        UserSession userSession;
        int bookID;
        string bookDetails;
        int stockLevel;
        int totalStockLevel;

        public ChangeBookQuantityForm(ref UserSession userSession, int bookID, string bookDetails, int stockLevel, int totalStockLevel)
        {
            //new ChangeBookQuantityForm(ref userSession, bookID, bookDetails, stockLevel, totalStockLevel);
            InitializeComponent();
            this.userSession = userSession;
            this.bookID = bookID;
            this.bookDetails = bookDetails;
            this.stockLevel = stockLevel;
            this.totalStockLevel = totalStockLevel;
        }

        private void ChangeBookQuantityForm_Load(object sender, EventArgs e)
        {
            toChangeInfoLabel.Text = bookDetails;
            quantityChangeUpDown.Minimum = -stockLevel;
            afterChangeQuantityInfoLabel.Text = (stockLevel + quantityChangeUpDown.Value).ToString() + "/" + (stockLevel + quantityChangeUpDown.Value).ToString();

        }

        private void quantityChangeUpDown_ValueChanged(object sender, EventArgs e)
        {
            afterChangeQuantityInfoLabel.Text = (stockLevel + quantityChangeUpDown.Value).ToString() + "/" + (totalStockLevel + quantityChangeUpDown.Value).ToString();
        }

        private void cancelQuantityChangeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmQuantityChangeButton_Click(object sender, EventArgs e)
        {
            /*
             * - QUANTITY CHANGE FUNCTION RETURN VALUES -
             * 0 - successfull
             * 1 - not logged in
             * 3 - no permissions
             * 4 - sql/other error
             * 5 - invalid/empty parameters
             * 6 - insufficent stock
             */

            int quantityChangeResult = LibraryManagement.ModifyBookStockLevel(ref userSession, bookID, (int)quantityChangeUpDown.Value);
            switch (quantityChangeResult)
            {
                case 0:
                    //success
                    quantityChangeErrorLabel.Text = String.Empty;
                    MessageBox.Show("Zmiana stanu magazynowego książki zakończona sukcesem. ");
                    Close();
                    break;
                case 1:
                    quantityChangeErrorLabel.Text = "Użytkownik nie jest zalogowany. ";
                    break;
                case 3:
                    quantityChangeErrorLabel.Text = "Brak uprawnień do wykonania uperacji. ";
                    break;
                case 4:
                    quantityChangeErrorLabel.Text = "Wystąpił nieznany błąd. ";
                    break;
                case 5:
                    quantityChangeErrorLabel.Text = "Podano błędne parametry. ";
                    break;
                case 6:
                    quantityChangeErrorLabel.Text = "Niewystarczająca ilość egzemplarzy do zrealizowania operacji. ";
                    break;
                default:
                    quantityChangeErrorLabel.Text = "Wystąpił nieobługiwany wyjątek. ";
                    break;
            }

        }
    }
}
