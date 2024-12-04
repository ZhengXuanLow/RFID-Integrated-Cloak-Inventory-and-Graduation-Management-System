﻿using System;
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
    public partial class gmsMenu : Form
    {
        public gmsMenu()
        {
            InitializeComponent();
        }

        private void gmsMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

            bottomBar.BackColor = ColorTranslator.FromHtml("#1E427E");
            sloganLabel.BackColor = ColorTranslator.FromHtml("#1E427E");
        }

        private void returnPictureBox_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void campusCIButton_Click(object sender, EventArgs e)
        {
            sucCheckIn sucCheckIn = new sucCheckIn();
            sucCheckIn.Show();
            this.Hide();
        }

        private void MPHCIbutton_Click(object sender, EventArgs e)
        {
            MPHCheckIn MPHCheckIn = new MPHCheckIn();
            MPHCheckIn.Show();
            this.Hide();
        }

        private void returnPictureBox_Click_1(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
