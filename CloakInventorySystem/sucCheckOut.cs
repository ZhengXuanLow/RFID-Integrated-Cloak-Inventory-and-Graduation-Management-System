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
    public partial class sucCheckOut : Form
    {
        bool QRMode = true;
        bool rfidMode = false;
        bool confirmInfoA = false;
        bool confirmInfoB = false;
        string currentQRCode = string.Empty;
        string currentRFIDCode = string.Empty;

        string currentStudentID = string.Empty;
        string currentStudentAge = string.Empty;
        string currentStudentFaculty = string.Empty;
        string currentStudentName = string.Empty;
        string currentStudentProgram = string.Empty;
        string currentStudentGraduation = string.Empty;
        string currentSize = string.Empty;

        public sucCheckOut()
        {
            InitializeComponent();
        }


        void showRFIDRelatedTextboxHideGIF()
        {
            rfidGif.Visible = false;
            nameLabel.Visible = true;
            studentIDLabel.Visible = true;
            ageLabel.Visible = true;
            facultyLabel.Visible = true;
            programLabel.Visible = true;
            graduateLabel.Visible = true;
            cloakSize1Label.Visible = true;

            nameTextBox.Visible = true;
            studentIDTextBox.Visible = true;
            ageTextBox.Visible = true;
            facultyTextBox.Visible = true;
            programTextBox.Visible = true;
            graduateTextBox.Visible = true;
            cloakSizeTextBox.Visible = true;
        }



        void hideRFIDRelatedTextboxShowGIF()
        {
            nameLabel.Visible = false;
            studentIDLabel.Visible = false;
            ageLabel.Visible = false;
            facultyLabel.Visible = false;
            programLabel.Visible = false;
            graduateLabel.Visible = false;
            cloakSize1Label.Visible = false;
            cloakSizeTextBox.Visible = false;
            rfidGuideLabel.Visible = true;

            nameTextBox.Visible = false;
            studentIDTextBox.Visible = false;
            ageTextBox.Visible = false;
            facultyTextBox.Visible = false;
            programTextBox.Visible = false;
            graduateTextBox.Visible = false;
            cloakSize1Label.Visible = false;
            cloakSizeTextBox.Visible = false;
        }

        void resetAllTextBox()
        {
            nameTextBox.Text = "";
            studentIDTextBox.Text = "";
            ageTextBox.Text = "";
            facultyTextBox.Text = "";
            programTextBox.Text = "";
            graduateTextBox.Text = "";
            cloakSize1Label.Text = "";

        }

        private void borrowCloak_Load(object sender, EventArgs e)
        {

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;

            bottomBar.BackColor = ColorTranslator.FromHtml("#1E427E");
            sloganLabel.BackColor = ColorTranslator.FromHtml("#1E427E");

            hideRFIDRelatedTextboxShowGIF();
            rfidGif.Visible = true;

        }

        private void UserInputTextBox_TextChanged(object sender, EventArgs e)
        {

            {
                if (currentRFIDCode == string.Empty)
                {
                    if (UserInputTextBox.Text.Length > 9)
                    {
                        getStudentInfo(UserInputTextBox.Text);
                        getCloakSize(UserInputTextBox.Text);
                        currentRFIDCode = UserInputTextBox.Text;
                        showRFIDRelatedTextboxHideGIF();

                        if (!confirmInfoB)
                        {
                            rfidGuideLabel.Visible = false;
                            showRFIDRelatedTextboxHideGIF();
                            confirmRFIDLabel.Visible = true;
                            cloakSize1Label.Visible = true;
                            UserInputTextBox.Text = "";

                        }

                    }
                }

                else
                        if (currentRFIDCode != string.Empty)
                {
                    if (UserInputTextBox.Text.Length > 9)
                    {
                        if (currentRFIDCode == UserInputTextBox.Text)
                        {
                            QRMode = false;
                            rfidMode = false;

                            rfidGuideLabel.Visible = true;
                            confirmRFIDLabel.Visible = false;
                            UserInputTextBox.Text = string.Empty;
                            setStatus(currentStudentID);
                            autoClosingMessageBox.Show("Status Updated, system redirect after 3 seconds", "Thank You", 3000);
                            resetAll();
                            hideRFIDRelatedTextboxShowGIF();
                            
                        }
                    }
                }
            }

        }

        void getStudentInfo(string RFIDContent)
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
                    JOIN 
                    department d ON c.departmentID = d.departmentID
                    JOIN
                    cloak k ON s.studentID = k.studentID
                    WHERE 
                    k.rfidID = @RFIDContent";


                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RFIDContent", RFIDContent);
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

                        currentStudentID = studentID;
                        currentStudentAge = age;
                        currentStudentFaculty = faculty;
                        currentStudentName = name;
                        currentStudentProgram = courseName;
                        currentStudentGraduation = readyGradute;

                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }




        }

        void getCloakSize(string RFIDContent)
        {
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    string query = @"
                    SELECT rfidID, size
                    FROM cloak
                    WHERE rfidID = @RFID;";


                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RFID", RFIDContent);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string size = reader["size"].ToString();
                        cloakSizeTextBox.Text = size;
                        currentSize = size;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }


            }




        }



        void resetAll()
        {
            QRMode = true;
            rfidMode = false;
            confirmInfoA = false;
            confirmInfoB = false;
            currentQRCode = string.Empty;
            currentRFIDCode = string.Empty;

            currentStudentID = string.Empty;
            currentStudentAge = string.Empty;
            currentStudentFaculty = string.Empty;
            currentStudentName = string.Empty;
            currentStudentProgram = string.Empty;
            currentStudentGraduation = string.Empty;
            currentSize = string.Empty;
            rfidGif.Visible = true;
        }

        void setStatus(string studentID)
        {
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "UPDATE student SET currentStatusID = '8' WHERE studentID = @studentID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {

                        }
                        else
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnPictureBox_Click(object sender, EventArgs e)
        {
            gmsMenu gmsMenu = new gmsMenu();
            gmsMenu.Show();
            this.Close();
        }
    }
}
