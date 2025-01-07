using Microsoft.VisualBasic.Devices;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
using Microsoft.CognitiveServices.Speech;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;
using CsvHelper;
using System.Globalization;
using Microsoft.VisualBasic.FileIO;

namespace CloakInventorySystem
{
    public partial class dataListView : Form
    {
        string currentStudentID = "";
        string currentIC = "";
        string currentRfidID = "";
        string currentStatus = "";
        string currentSpeech = "";

        public dataListView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            bottomBar.BackColor = ColorTranslator.FromHtml("#1E427E");
            nameLabel.BackColor = ColorTranslator.FromHtml("#1E427E");
            LoadDataIntoDataGridView(dataGridView);
            dataGridView.CellClick += new DataGridViewCellEventHandler(dataGridView_CellClick);
        }

        private void returnPictureBox_Click(object sender, EventArgs e)
        {
            cisMenu cisMenu = new cisMenu();
            cisMenu.Show();
            this.Close();
        }


        public void LoadDataIntoDataGridView(DataGridView dgv)
        {
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = @"
            SELECT 
        s.studentID, 
        s.name, 
        s.age,  
        c.courseName AS courseName, 
        s.invitationCode, 
        cl.rfidID,
        cs.status AS currentStatus,
        s.graduationSpeech
        FROM 
        student s
        LEFT JOIN 
        course c ON s.courseID = c.courseID
        LEFT JOIN 
        cloak cl ON s.studentID = cl.studentID
        LEFT JOIN
        currentStatus cs ON s.currentStatusID = cs.currentStatusID;
            ";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgv.DataSource = table;
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check that the user clicked a valid row (not the header)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];


                currentStudentID = row.Cells["studentID"].Value.ToString();
                nameTextBox.Text = row.Cells["name"].Value.ToString();
                ICTextBox.Text = row.Cells["invitationCode"].Value.ToString();
                statusComboBox.SelectedIndex = getCurrentIndex(currentStudentID);
                rfidTextBox.Text = row.Cells["rfidID"].Value.ToString();
                speechrichTextBox.Text = row.Cells["graduationSpeech"].Value.ToString();

                getCurrentStudentInfo();

            }
        }

        void getCurrentStudentInfo()
        {
            currentIC = ICTextBox.Text;
            currentRfidID = rfidTextBox.Text;
            currentStatus = statusComboBox.Text;
            currentSpeech = speechrichTextBox.Text;
        }

        private void searchStudentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            rfidTextBox.Text = "";
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            // Adjust SQL query to allow partial matching using LIKE
            string query = @"
            SELECT 
            s.studentID, 
            s.name, 
            s.age,  
            c.courseName AS courseName, 
            s.invitationCode, 
            cl.rfidID,
            cs.status AS currentStatus,
            s.graduationSpeech
            FROM 
            student s
            JOIN 
            course c ON s.courseID = c.courseID
            JOIN 
            cloak cl ON s.studentID = cl.studentID
            JOIN
            currentStatus cs ON s.currentStatusID = cs.currentStatusID
            WHERE 
            s.studentID LIKE @StudentID;";

            // Get the studentID from the TextBox
            TextBox searchTextBox = (TextBox)sender; // The sender is the searchStudentIDTextBox
            string studentID = searchTextBox.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameter with a wildcard for partial matching
                    command.Parameters.AddWithValue("@StudentID", $"%{studentID}%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Bind the DataTable to the DataGridView
                    dataGridView.DataSource = table;
                }
            }

            // Adjust DataGridView settings
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void searchRFIDTextBox_TextChanged(object sender, EventArgs e)
        {
            searchStudentIDTextBox.Text = "";
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            // SQL query to search by RFID ID using LIKE
            string query = @"
            SELECT 
            s.studentID, 
            s.name, 
            s.age,  
            c.courseName AS courseName, 
            s.invitationCode, 
            cl.rfidID,
            cs.status AS currentStatus,
            s.graduationSpeech
            FROM 
            student s
            JOIN 
            course c ON s.courseID = c.courseID
            JOIN 
            cloak cl ON s.studentID = cl.studentID
            JOIN
            currentStatus cs ON s.currentStatusID = cs.currentStatusID
            WHERE 
            cl.rfidID LIKE @RFIDID;";

            // Get the RFID ID from the TextBox
            TextBox searchRFIDTextBox = (TextBox)sender; // The sender is the searchRFIDTextBox
            string rfidID = searchRFIDTextBox.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameter with a wildcard for partial matching
                    command.Parameters.AddWithValue("@RFIDID", $"%{rfidID}%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Bind the DataTable to the DataGridView
                    dataGridView.DataSource = table;
                }
            }

            // Adjust DataGridView settings
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Scan the admin Card", "Update Student Information");
            if (input != "0688503939")
            {
                MessageBox.Show("Incorrect Card", "Error");
                return;
            }
            updateInvitationCode(currentStudentID);
            updateRfidID(currentStudentID);
            updateCurrentStatus(currentStudentID);
            updateGraduationSpeech(currentStudentID);

            MessageBox.Show("Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataIntoDataGridView(dataGridView);
        }

        void updateInvitationCode(String currentStudentID)
        {
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            // Value from the ICTextBox
            string newInvitationCode = ICTextBox.Text;

            // Ensure currentStudent is defined and valid
            if (string.IsNullOrEmpty(currentStudentID))
            {
                MessageBox.Show("Current student is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure invitation code is provided
            if (string.IsNullOrEmpty(newInvitationCode))
            {
                MessageBox.Show("Please enter a valid invitation code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE student SET invitationCode = @invitationCode WHERE studentID = @currentStudent";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@invitationCode", newInvitationCode);
                        command.Parameters.AddWithValue("@currentStudent", currentStudentID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            //MessageBox.Show("Invitation code updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No student record found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void updateRfidID(String currentStudentID)
        {
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            // Value from the ICTextBox
            string newrfidId = rfidTextBox.Text;

            // Ensure currentStudent is defined and valid
            if (string.IsNullOrEmpty(currentStudentID))
            {
                MessageBox.Show("Current student is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrEmpty(newrfidId))
            {
                MessageBox.Show("Please borrow the cloak first to update rfidID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE cloak SET rfidID = @rfidID WHERE studentID = @currentStudent";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@rfidID", rfidTextBox.Text);
                        command.Parameters.AddWithValue("@currentStudent", currentStudentID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            //MessageBox.Show("RFID updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No student record found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateCurrentStatus(String currentStudentID)
        {
            // Assuming currentStudentID is a valid variable that holds the current student's ID
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            // Ensure currentStudentID is defined and valid
            if (string.IsNullOrEmpty(currentStudentID))
            {
                MessageBox.Show("Current student is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure a status is selected in the ComboBox
            if (statusComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected status ID from the ComboBox (assuming it holds numeric IDs as values)
            int selectedStatusID = statusComboBox.SelectedIndex;
            selectedStatusID++;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Update the student's current status ID in the student table
                    string query = "UPDATE student SET currentStatusID = @currentStatusID WHERE studentID = @currentStudentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@currentStatusID", selectedStatusID);
                        command.Parameters.AddWithValue("@currentStudentID", currentStudentID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            //MessageBox.Show("Student status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No student record found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void updateGraduationSpeech(String currentStudentID)
        {
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            if (string.IsNullOrEmpty(currentStudentID))
            {
                MessageBox.Show("Current student is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure the graduation speech text box is not empty
            if (string.IsNullOrEmpty(speechrichTextBox.Text))
            {
                MessageBox.Show("Please enter a graduation speech.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to update the graduationSpeech column for the current student
                    string query = "UPDATE student SET graduationSpeech = @graduationSpeech WHERE studentID = @currentStudentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@graduationSpeech", speechrichTextBox.Text);
                        command.Parameters.AddWithValue("@currentStudentID", currentStudentID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            //MessageBox.Show("Graduation speech updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Please Borrow the Cloak first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int getCurrentIndex(String currentStudentID)
        {
            // Connection string to your SQL Server database
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            // SQL query to retrieve the currentStatusID for the student
            string query = "SELECT currentStatusID FROM student WHERE studentID = @StudentID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@StudentID", currentStudentID);

                try
                {
                    conn.Open();

                    // Execute the query and get the currentStatusID
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        // Convert the result to int and return it
                        return Convert.ToInt32(result) - 1;
                    }
                    else
                    {
                        // Return a default value if no status is found
                        throw new Exception("Current status ID not found for the student.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions (e.g., connection issues, invalid student ID, etc.)
                    MessageBox.Show("Error: " + ex.Message);
                    return -1; // Return -1 as an error code
                }
            }
        }



        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Scan the admin Card", "Delete Student Table");

                
                if (input != "0688503939")
                {
                    MessageBox.Show("Incorrect card", "Error");
                return;
                }
           

            

            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "DELETE FROM student"; // This will delete all rows

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowsAffected = command.ExecuteNonQuery();

                    //MessageBox.Show($"{rowsAffected} rows deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            MessageBox.Show("Deleted Success", "Success");
            LoadDataIntoDataGridView(dataGridView);
            

            
        }

        private void refreshF5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(dataGridView);
        }

        private void importToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select CSV File",
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                DefaultExt = "csv"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

                try
                {
                    using (TextFieldParser parser = new TextFieldParser(filePath))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(",");
                        parser.HasFieldsEnclosedInQuotes = true;

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            using (SqlTransaction transaction = conn.BeginTransaction())
                            {
                                try
                                {
                                    parser.ReadLine(); // Skip header

                                    while (!parser.EndOfData)
                                    {
                                        string[] fields = parser.ReadFields();

                                        string query = @"INSERT INTO student 
                                                (studentID, name, age, readyGraduate, courseID, currentStatusID, invitationCode, graduationSpeech) 
                                                VALUES 
                                                (@studentID, @name, @age, @readyGraduate, @courseID, @currentStatusID, @invitationCode, @graduationSpeech)";

                                        using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                                        {
                                            cmd.Parameters.AddWithValue("@studentID", fields[0]);
                                            cmd.Parameters.AddWithValue("@name", fields[1]);
                                            cmd.Parameters.AddWithValue("@age", Convert.ToInt32(fields[2]));
                                            cmd.Parameters.AddWithValue("@readyGraduate", Convert.ToInt32(fields[3]));
                                            cmd.Parameters.AddWithValue("@courseID", Convert.ToInt32(fields[4]));
                                            cmd.Parameters.AddWithValue("@currentStatusID", Convert.ToInt32(fields[5]));
                                            cmd.Parameters.AddWithValue("@invitationCode", fields[6]);
                                            cmd.Parameters.AddWithValue("@graduationSpeech", fields[7]);

                                            cmd.ExecuteNonQuery();
                                        }
                                    }

                                    transaction.Commit();
                                    MessageBox.Show("Data imported successfully!");
                                    LoadDataIntoDataGridView(dataGridView);
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show($"Error: {ex.Message}");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File read error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No file selected.");
            }
        }
    }
}
