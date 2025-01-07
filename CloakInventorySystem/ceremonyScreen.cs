using Microsoft.VisualBasic.Devices;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
using Microsoft.CognitiveServices.Speech;
using System.Windows.Forms;

namespace CloakInventorySystem
{
    public partial class ceremonyScreen : Form
    {
        private System.Windows.Forms.Timer timer;
        private int currentStudent = 0;
        private const string AzureSpeechKey = "Fo0tIX3gYlmB8sV8BZOobYHy3Jm5ala7xYb5M278IO6akxEHbwjOJQQJ99AKACqBBLyXJ3w3AAAYACOGpxD6";
        private const string AzureServiceRegion = "southeastasia";

        static string prevName = "";
        static string prevCourseName = "";
        static string prevDepartmentName = "";
        static string prevGraduationSpeech = "";
        int prevStatusID = 0;
        static bool hasRun = false;

        public ceremonyScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;

            nameLabel.BackColor = Color.Transparent;
            courseLabel.BackColor = Color.Transparent;
            facultyLabel.BackColor = Color.Transparent;
            graduationLabel.BackColor = Color.Transparent;
            getStudentInfo();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; // Set interval to 1 second (1000 milliseconds)
            timer.Tick += Timer_Tick; // Attach the event handler
            timer.Start();
        }

        void getStudentInfo()
        {
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    string query = @"
                SELECT TOP 1 
                s.name,
                s.graduationSpeech,
                c.courseName, 
                d.departmentName,
                s.currentStatusID
                FROM queueTable q
                INNER JOIN student s ON q.studentID = s.studentID
                JOIN 
                course c ON s.courseID = c.courseID
                JOIN department d ON c.departmentID = d.departmentID";


                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

      
                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string courseName = reader["courseName"].ToString();
                        string departmentName = reader["departmentName"].ToString();
                        string graduationSpeech = reader["graduationSpeech"].ToString();
                        int currentStatusID = reader["currentStatusID"] != DBNull.Value ? Convert.ToInt32(reader["currentStatusID"]) : 0;

                        bool isSameResult = (name == prevName && courseName == prevCourseName && departmentName == prevDepartmentName && graduationSpeech == prevGraduationSpeech && currentStatusID == prevStatusID);

                        if (currentStatusID == 6 && isSameResult && !hasRun)
                        {
                            nameLabel.Text = "";
                            courseLabel.Text = "";
                            facultyLabel.Text = "";
                            graduationLabel.Text = "";

                            nameLabel.Text = name;
                            courseLabel.Text = courseName;
                            facultyLabel.Text = departmentName;
                            graduationLabel.Text = graduationSpeech;
                            textToSpeechAsync();
                            hasRun = true;
                        }
                        else if (!isSameResult)
                        {
                            hasRun = false;
                        }

                        // Update previous values
                        prevName = name;
                        prevCourseName = courseName;
                        prevDepartmentName = departmentName;
                        prevGraduationSpeech = graduationSpeech;
                        prevStatusID = currentStatusID;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }











        private void Timer_Tick(object sender, EventArgs e)
        {
            // Call your function here
            getStudentInfo();
        }

        async Task textToSpeechAsync()
        {
            string TTSText = nameLabel.Text + ". " + facultyLabel.Text + ". " + courseLabel.Text + ". " + graduationLabel.Text;
            var config = SpeechConfig.FromSubscription(AzureSpeechKey, AzureServiceRegion);

            using (var synthesizer = new SpeechSynthesizer(config))
            {
                // TTS
                var result = await synthesizer.SpeakTextAsync(TTSText);

                // Check
                if (result.Reason == ResultReason.SynthesizingAudioCompleted)
                {
                    //MessageBox.Show("Speech synthesis completed.");
                }
                else if (result.Reason == ResultReason.Canceled)
                {
                    var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
                    //MessageBox.Show($"Error: {cancellation.ErrorDetails}");
                }
            }

        }
    }
}
