using Microsoft.Data.SqlClient;
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
    public partial class borrowCloak : Form
    {
        bool QRMode = true;
        bool rfidMode = false;

        public borrowCloak()
        {
            InitializeComponent();
        }

        void showQRRelatedTextboxHideGIF()
        {
            nameLabel.Visible = true;
            studentIDLabel.Visible = true;
            ageLabel.Visible = true;
            facultyLabel.Visible = true;
            programLabel.Visible = true;
            graduateLabel.Visible = true;
            cloakSizeLabel.Visible = true;

            nameTextBox.Visible = true;
            studentIDTextBox.Visible = true;
            ageTextBox.Visible = true;
            facultyTextBox.Visible = true;
            programTextBox.Visible = true;
            graduateTextBox.Visible = true;
            cloakSizeLabel.Visible = false;
        }

        void hideQRRelatedTextboxShowGIF()
        {
            nameLabel.Visible = false;
            studentIDLabel.Visible = false;
            ageLabel.Visible = false;
            facultyLabel.Visible = false;
            programLabel.Visible = false;
            graduateLabel.Visible = false;
            cloakSizeLabel.Visible = false;
            nameTextBox.Visible = false;
            studentIDTextBox.Visible = false;
            ageTextBox.Visible = false;
            facultyTextBox.Visible = false;
            programTextBox.Visible = false;
            graduateTextBox.Visible = false;
            cloakSizeLabel.Visible = false;
        }

        void resetAllTextBox()
        {
            nameTextBox.Text = "";
            studentIDTextBox.Text = "";
            ageTextBox.Text = "";
            facultyTextBox.Text = "";
            programTextBox.Text = "";
            graduateTextBox.Text = "";
            cloakSizeLabel.Text = "";
        }

        private void borrowCloak_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

            bottomBar.BackColor = ColorTranslator.FromHtml("#1E427E");
            sloganLabel.BackColor = ColorTranslator.FromHtml("#1E427E");

            hideQRRelatedTextboxShowGIF();
        }

        private void UserInputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QRMode == true && rfidMode == false)
            {
                if (UserInputTextBox.Text.Length > 4)
                {
                    resetAllTextBox();
                    showQRRelatedTextboxHideGIF();
                    scanQR1QueryFunction(UserInputTextBox.Text);

                }
            }
            else if (QRMode == false && rfidMode == true)
            {

            }
        }

        void scanQR1QueryFunction(string qrCodeContent)
        {
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    string query = @"
                    SELECT 
                    s.studentID, 
                    s.name, 
                    s.age, 
                    s.readyGraduate, 
                    s.courseID, 
                    s.invitationCode,
                    c.courseName,
                    d.departmentName
                    FROM 
                    student s
                    JOIN 
                    course c ON s.courseID = c.courseID
                    JOIN department d ON c.departmentID = d.departmentID
                    WHERE 
                    s.invitationCode = @QRCODE;";


                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@QRCODE", qrCodeContent);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string studentID = reader["studentID"].ToString();
                        string name = reader["name"].ToString();
                        string age = reader["age"].ToString();
                        string readyGradute = reader["readyGraduate"].ToString();
                        string courseName = reader["courseName"].ToString();
                        string faculty = reader["departmentName"].ToString();

                        nameTextBox.Text = name;
                        studentIDTextBox.Text = studentID;
                        ageTextBox.Text = age;
                        facultyTextBox.Text = faculty;
                        programTextBox.Text = courseName;
                        graduateTextBox.Text = readyGradute;

                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            


        }


    }
}
