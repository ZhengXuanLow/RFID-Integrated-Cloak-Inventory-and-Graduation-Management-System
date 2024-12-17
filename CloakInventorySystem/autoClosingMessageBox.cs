using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CloakInventorySystem
{

    public class autoClosingMessageBox : Form
    {
        private System.Windows.Forms.Timer timer; // Explicitly specify System.Windows.Forms.Timer

        public autoClosingMessageBox(string message, string title, int duration)
        {
            // Set up the form
            this.Text = title;
            this.Size = new Size(300, 150);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Add a label for the message
            Label label = new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 12),
            };
            this.Controls.Add(label);

            // Set up the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = duration; // Duration in milliseconds
            timer.Tick += Timer_Tick; // Attach event handler for Tick
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Stop the timer
            this.Close(); // Close the message box
        }

        public static void Show(string message, string title, int duration)
        {
            using (var messageBox = new autoClosingMessageBox(message, title, duration))
            {
                messageBox.ShowDialog();
            }
        }
    }

    
    
}
