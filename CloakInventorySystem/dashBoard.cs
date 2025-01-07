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
using System.Windows.Forms.DataVisualization.Charting;

namespace CloakInventorySystem
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
        }

        private void cisMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;

            bottomBar.BackColor = ColorTranslator.FromHtml("#1E427E");
            sloganLabel.BackColor = ColorTranslator.FromHtml("#1E427E");
            generateBorrowPieChart();
            generateStatusBarChart();
            generatePieChart();
        }

        private void returnPictureBox_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Close();
        }


        private void generateBorrowPieChart()
        {
            // Step 1: Retrieve data counts from the database
            int studentCount = getCountWithStudentID();
            int cloakCountWithEmptyStudentID = getCountWithoutStudentID();

            // Step 2: Configure and populate the existing pie chart (borrowChart)
            borrowChart.Series.Clear(); // Clear any existing data

            var series = new Series
            {
                Name = "Borrow Data",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            // Add data points
            series.Points.AddXY("Student Done Borrow", studentCount);
            series.Points.AddXY("Student Not Done Borrow", cloakCountWithEmptyStudentID);

            // Add series to chart
            borrowChart.Series.Add(series);

            // Customize chart title
            if (borrowChart.Titles.Count == 0)
            {
                borrowChart.Titles.Add("");
            }
            else
            {
                borrowChart.Titles[0].Text = "";
            }

            MakeChartTransparent(borrowChart);
        }

        private int getCountWithStudentID()
        {
            const string query = "SELECT COUNT(*) FROM Student INNER JOIN Cloak ON Student.StudentID = Cloak.StudentID;";
            return ExecuteScalarQuery(query);
        }

        private int getCountWithoutStudentID()
        {
            const string query = "SELECT COUNT(*) FROM Student LEFT JOIN Cloak ON Student.StudentID = Cloak.StudentID WHERE Cloak.StudentID IS NULL;";
            return ExecuteScalarQuery(query);
        }

        private int ExecuteScalarQuery(string query)
        {
            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private void MakeChartTransparent(Chart chart)
        {
            // Set the chart's background to transparent
            borrowChart.BackColor = Color.Transparent;

            // Set the chart area background to transparent
            foreach (var chartArea in chart.ChartAreas)
            {
                chartArea.BackColor = Color.Transparent;
            }

            // Set the series background to transparent
            foreach (var series in chart.Series)
            {
                series.LabelBackColor = Color.Transparent;
            }

            // Optional: Set legend background to transparent
            foreach (var legend in chart.Legends)
            {
                legend.BackColor = Color.Transparent;
            }
        }

        //statusChart

        private void generateStatusBarChart()
        {
            // Step 1: Retrieve data counts from the database
            var statusData = getStatusCounts();

            // Step 2: Configure and populate the existing bar chart (statusChart)
            statusChart.Series.Clear(); // Clear any existing data
            statusChart.ChartAreas.Clear(); // Clear any existing chart areas

            // Add a new chart area
            var chartArea = new ChartArea
            {
                Name = "StatusChartArea",
                AxisX = { Title = "Current Status", Interval = 1 },
                AxisY = { Title = "Number of Students" }
            };
            statusChart.ChartAreas.Add(chartArea);

            // Create a new series for the bar chart
            var series = new Series
            {
                Name = "Students",
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            // Populate series with data
            foreach (var dataPoint in statusData)
            {
                series.Points.AddXY(dataPoint.Key, dataPoint.Value);
            }

            // Add series to the chart
            statusChart.Series.Add(series);

            // Customize chart title
            if (statusChart.Titles.Count == 0)
            {
                statusChart.Titles.Add("");
            }
            else
            {
                statusChart.Titles[0].Text = "";
            }

            MakeChartTransparent(statusChart);
        }

        private Dictionary<int, int> getStatusCounts()
        {
            const string query = @"
                SELECT currentStatusID, COUNT(*) AS TotalCount
                FROM Student
                GROUP BY currentStatusID;";

            var statusCounts = new Dictionary<int, int>();

            string connectionString = "Server=tcp:rfidcis.database.windows.net,1433;Initial Catalog=rfidcis;Persist Security Info=False;User ID=CloudSA5def8d30;Password=Tg7$wr!9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int statusID = reader.GetInt32(0); // currentStatusID
                            int count = reader.GetInt32(1);    // TotalCount
                            statusCounts[statusID] = count;
                        }
                    }
                }
            }

            // Ensure all status IDs (1 to 8) are present with a count of 0 if missing
            for (int i = 1; i <= 8; i++)
            {
                if (!statusCounts.ContainsKey(i))
                {
                    statusCounts[i] = 0;
                }
            }

            return statusCounts;
        }

        //completeProgress

        private void generatePieChart()
        {
            // Step 1: Retrieve data counts from the database
            int countStatus8 = GetCountStatus8();
            int countNotStatus8AndNotStatus1 = GetCountNotStatus8AndNotStatus1();

            // Step 2: Configure and populate the existing pie chart (completeChart)
            completeChart.Series.Clear(); // Clear any existing data

            var series = new Series
            {
                Name = "StudentStatus",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            // Add data points for the pie chart
            series.Points.AddXY("Status 8 (Return)", countStatus8);
            series.Points.AddXY("Other Statuses (Not 8 and Not 1)", countNotStatus8AndNotStatus1);

            // Add series to chart
            completeChart.Series.Add(series);

            // Customize chart title
            if (completeChart.Titles.Count == 0)
            {
                completeChart.Titles.Add("");
            }
            else
            {
                completeChart.Titles[0].Text = "";
            }

            MakeChartTransparent(completeChart);
        }

        private int GetCountStatus8()
        {
            const string query = "SELECT COUNT(*) FROM Student WHERE currentStatusID = 8;";
            return ExecuteScalarQuery(query);
        }

        private int GetCountNotStatus8AndNotStatus1()
        {
            const string query = "SELECT COUNT(*) FROM Student WHERE currentStatusID != 8 AND currentStatusID != 1;";
            return ExecuteScalarQuery(query);
        }

        private void refreshF5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateBorrowPieChart();
            generateStatusBarChart();
            generatePieChart();
        }

        private void borrowChart_Click(object sender, EventArgs e)
        {

        }
    }
}
