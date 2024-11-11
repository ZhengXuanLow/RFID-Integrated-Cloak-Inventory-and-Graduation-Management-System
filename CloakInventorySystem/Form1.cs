using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System.Xml.Linq;
using Microsoft.CognitiveServices.Speech;

namespace CloakInventorySystem
{
    public partial class Form1 : Form
    {
        private const string AzureSpeechKey = "Fo0tIX3gYlmB8sV8BZOobYHy3Jm5ala7xYb5M278IO6akxEHbwjOJQQJ99AKACqBBLyXJ3w3AAAYACOGpxD6";
        private const string AzureServiceRegion = "southeastasia";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Main Here
            RFIDtextbox.Focus();
            connectionTest();
            testFunction();
        }

        void connectionTest()
        {
            string connectionString = "Server=localhost;Database=cis;User ID=root;Password=;"; // Adjust user ID and password if necessary

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        static void testFunction()
        {
            string connectionString = "Server=localhost;Database=cis;User ID=root;Password=;"; 

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    string query = @"
                        SELECT cloak.rfidID, cloak.studentID, s.name, c.courseName, d.departmentName
                        FROM cloak 
                        LEFT JOIN student s ON cloak.studentID = s.studentID
                        LEFT JOIN course c ON s.courseID = c.courseID
                        LEFT JOIN department d ON c.departmentID = d.departmentID
";


                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string rfidID = reader["rfidID"].ToString();
                        string studentID = reader["studentID"].ToString();
                        string name = reader["name"].ToString();
                        string course = reader["courseName"].ToString();
                        string department = reader["departmentName"].ToString();

                        Console.WriteLine($"RFID ID: {rfidID}, Student ID: {studentID}, Name: {name}, Course:{course}, Department:{department}");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }



        }

        private void RFIDtextbox_TextChanged(object sender, EventArgs e)
        {
            if (RFIDtextbox.Text.Length > 9)
            {
                queryFunction(RFIDtextbox.Text);
            }
        }

        void queryFunction(string RFIDID)
        {
            StudentIDTextBox.Text = string.Empty;
            StudentNameTextBox.Text = string.Empty;
            courseTextBox.Text = string.Empty;
            DepartmentNameTextBox.Text = string.Empty;
            RFIDtextbox.Text = string.Empty;

            string connectionString = "Server=localhost;Database=cis;User ID=root;Password=;"; 

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    string query = @"
                        SELECT cloak.rfidID, cloak.studentID, s.name, c.courseName, d.departmentName
                        FROM cloak 
                        LEFT JOIN student s ON cloak.studentID = s.studentID
                        LEFT JOIN course c ON s.courseID = c.courseID
                        LEFT JOIN department d ON c.departmentID = d.departmentID
                        WHERE cloak.rfidID = @RFIDID
";


                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RFIDID", RFIDID);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string rfidID = reader["rfidID"].ToString();
                        string studentID = reader["studentID"].ToString();
                        string name = reader["name"].ToString();
                        string course = reader["courseName"].ToString();
                        string department = reader["departmentName"].ToString();

   
                        StudentIDTextBox.Text = studentID;
                        StudentNameTextBox.Text = name;
                        courseTextBox.Text = course;
                        DepartmentNameTextBox.Text = department;

                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                textToSpeechAsync(StudentNameTextBox.Text);
            }



        }

        async Task textToSpeechAsync(string textToSpeech)
        {
            string TTSText = StudentNameTextBox.Text;
            var config = SpeechConfig.FromSubscription(AzureSpeechKey, AzureServiceRegion);

            using (var synthesizer = new SpeechSynthesizer(config))
            {
                // Synthesize the text to speech
                var result = await synthesizer.SpeakTextAsync(TTSText);

                // Check if the synthesis was successful
                if (result.Reason == ResultReason.SynthesizingAudioCompleted)
                {
                    MessageBox.Show("Speech synthesis completed.");
                }
                else if (result.Reason == ResultReason.Canceled)
                {
                    var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
                    MessageBox.Show($"Error: {cancellation.ErrorDetails}");
                }
            }

        }

    }
}
