﻿using Microsoft.Data.SqlClient;
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
            cloakSize1Label.Visible = true;
            cloakSizeTextBox.Visible = false;
            QRGif.Visible = false;
            rfidGif.Visible = false;

            nameTextBox.Visible = true;
            studentIDTextBox.Visible = true;
            ageTextBox.Visible = true;
            facultyTextBox.Visible = true;
            programTextBox.Visible = true;
            graduateTextBox.Visible = true;
            cloakSizeTextBox.Visible = false;

        }

        void showRFIDRelatedTextboxHideGIF()
        {
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
            rfidGif.Visible = false;
            QRGif.Visible = false;
        }

        void hideQRRelatedTextboxShowGIF()
        {
            nameLabel.Visible = false;
            studentIDLabel.Visible = false;
            ageLabel.Visible = false;
            facultyLabel.Visible = false;
            programLabel.Visible = false;
            graduateLabel.Visible = false;
            cloakSize1Label.Visible = false;
            nameTextBox.Visible = false;
            studentIDTextBox.Visible = false;
            ageTextBox.Visible = false;
            facultyTextBox.Visible = false;
            programTextBox.Visible = false;
            graduateTextBox.Visible = false;
            cloakSizeTextBox.Visible = false;
            QRGif.Visible = true;
            rfidGif.Visible = true;
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
            rfidGif.Visible = true;
            QRGif.Visible = false;

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

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;

            bottomBar.BackColor = ColorTranslator.FromHtml("#1E427E");
            sloganLabel.BackColor = ColorTranslator.FromHtml("#1E427E");

            hideQRRelatedTextboxShowGIF();
            rfidGif.Visible = false;

        }

        private void UserInputTextBox_TextChanged(object sender, EventArgs e)
        {

            if (QRMode == true && rfidMode == false)
            {
                if (currentQRCode == string.Empty)
                {
                    if (UserInputTextBox.Text.Length > 5)
                    {

                        getStudentInfo(UserInputTextBox.Text);
                        showQRRelatedTextboxHideGIF();
                        currentQRCode = UserInputTextBox.Text;
                        UserInputTextBox.Text = string.Empty;
                        if (!confirmInfoA)
                        {
                            guideLabel.Visible = false;
                            guideConfirmLabel.Visible = true;
                        }

                    }


                }
                else if (currentQRCode != string.Empty)
                {
                    if (UserInputTextBox.Text.Length > 5)
                    {
                        if (currentQRCode == UserInputTextBox.Text)
                        {
                            QRMode = false;
                            rfidMode = true;
                            guideConfirmLabel.Visible = false;
                            rfidGuideLabel.Visible = true;
                            UserInputTextBox.Text = string.Empty;
                            hideRFIDRelatedTextboxShowGIF();
                        }
                    }
                }

            }

            else

                if (QRMode == false && rfidMode == true)
            {
                if (currentRFIDCode == string.Empty)
                {
                    if (UserInputTextBox.Text.Length > 9)
                    {
                        getCloakInfo(UserInputTextBox.Text);
                        currentRFIDCode = UserInputTextBox.Text;
                        showRFIDRelatedTextboxHideGIF();

                        if (!confirmInfoB)
                        {
                            guideLabel.Visible = false;
                            guideConfirmLabel.Visible = false;
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
                            guideConfirmLabel.Visible = false;
                            rfidGuideLabel.Visible = false;
                            confirmRFIDLabel.Visible = false;
                            UserInputTextBox.Text = string.Empty;
                            setStudentIDonCloak(currentRFIDCode, currentStudentID);
                            setStatus(currentStudentID);
                            autoClosingMessageBox.Show("Status Updated, system redirect after 3 seconds", "Thank You", 3000);
                            resetAll();
                            hideQRRelatedTextboxShowGIF();
                            guideLabel.Visible = true;
                            rfidGif.Visible = false;
                            QRGif.Visible = true;
                        }
                    }
                }
            }

        }

        void getStudentInfo(string qrCodeContent)
        {
            string connectionString = "";

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

        void getCloakInfo(string RFIDContent)
        {
            string connectionString = "";

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

        void setStudentIDonCloak(string RFIDID, string studentID)
        {

            string connectionString = "";
            string query = "UPDATE cloak SET studentID = @studentID WHERE rfidID = @RFIDID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.Parameters.AddWithValue("@RFIDID", RFIDID);

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

            rfidGif.Visible = false;
            QRGif.Visible = true;
        }

        void setStatus(string studentID)
        {
            string connectionString = "";
            string query = "UPDATE student SET currentStatusID = '2' WHERE studentID = @studentID";

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
            cisMenu cisMenu = new cisMenu();
            cisMenu.Show();
            this.Close();
        }
    }
}
