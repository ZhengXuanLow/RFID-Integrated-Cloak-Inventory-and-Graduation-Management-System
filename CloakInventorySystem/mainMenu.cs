using Microsoft.VisualBasic.Devices;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
using Microsoft.CognitiveServices.Speech;
using System.Windows.Forms;

namespace CloakInventorySystem
{
    public partial class mainMenu : Form
    {

        public mainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;

            bottomBar.BackColor = ColorTranslator.FromHtml("#1E427E");
            sloganLabel.BackColor = ColorTranslator.FromHtml("#1E427E");

        }

        private void cisButton_Click(object sender, EventArgs e)
        {
            cisMenu cisMenu = new cisMenu();
            cisMenu.Show();
            this.Hide();
        }

        private void gmsButton_Click(object sender, EventArgs e)
        {
            gmsMenu gmsMenu = new gmsMenu();
            gmsMenu.Show();
            this.Hide();
        }
    }
}
