using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloakInventorySystem
{
    public partial class cisMenu : Form
    {
        public cisMenu()
        {
            InitializeComponent();
        }

        private void cisMenu_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;

            bottomBar.BackColor = ColorTranslator.FromHtml("#1E427E");
            sloganLabel.BackColor = ColorTranslator.FromHtml("#1E427E");
        }

        private void returnPictureBox_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            borrowCloak borrowCloak = new borrowCloak();
            borrowCloak.Show();
            this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            returnCloak returnCloak = new returnCloak();
            returnCloak.Show();
            this.Hide();
        }

        private void cloakDLVButton_Click(object sender, EventArgs e)
        {
            dataListView dataListView = new dataListView();
            dataListView.Show();
            this.Hide();
        }
    }
}
