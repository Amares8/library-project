namespace Reszke
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void navTimeTimer_Tick(object sender, EventArgs e)
        {
            string navTimeLabelText = string.Empty;
            switch(((int)DateTime.Now.DayOfWeek))
            {
                case 0:
                    navTimeLabelText += "Niedziela";
                    break;
                case 1:
                    navTimeLabelText += "Poniedzia³ek";
                    break;
                case 2:
                    navTimeLabelText += "Wtorek";
                    break;
                case 3:
                    navTimeLabelText += "Œroda";
                    break;
                case 4:
                    navTimeLabelText += "Czwartek";
                    break;
                case 5:
                    navTimeLabelText += "Pi¹tek";
                    break;
                case 6:
                    navTimeLabelText += "Sobota";
                    break;
                
            }

            navTimeLabelText += "\n" + DateTime.Now.ToString("dd.MM.yyyy");
            navTimeLabelText += "\n" + DateTime.Now.ToString("HH:mm:ss");
            navTimeLabel.Text = navTimeLabelText;
        }
    }
}