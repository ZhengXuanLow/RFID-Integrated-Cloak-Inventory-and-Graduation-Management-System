using Microsoft.VisualBasic.Devices;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
using Microsoft.CognitiveServices.Speech;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace CloakInventorySystem
{
    public partial class dataListView : Form
    {
        string currentStudentID="";
        string currentIC = "";
        string currentRfidID = "";
        string currentStatus = "";

        public dataListView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;

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
            s.readyGraduate, 
            c.courseName AS courseName, 
            s.invitationCode, 
            cl.rfidID,
            cs.status AS currentStatus
            FROM 
            student s
            JOIN 
            course c ON s.courseID = c.courseID
            JOIN 
            cloak cl ON s.studentID = cl.studentID
            JOIN
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
                rfidTextBox.Text = row.Cells["rfidID"].Value.ToString();
                currentStatusTextBox.Text = row.Cells["currentStatus"].Value.ToString();

                getCurrentStudentInfo();

            }
        }

        void getCurrentStudentInfo()
        {
            currentIC = ICTextBox.Text;
            currentRfidID = rfidTextBox.Text;
            currentStatus = currentStatusTextBox.Text;
        }
    }
}
