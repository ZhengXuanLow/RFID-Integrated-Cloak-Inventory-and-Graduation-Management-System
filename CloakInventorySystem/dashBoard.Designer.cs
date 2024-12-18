namespace CloakInventorySystem
{
    partial class dashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            sloganLabel = new Label();
            bottomBar = new PictureBox();
            menuLabel = new Label();
            sucLogoPictureBox = new PictureBox();
            returnPictureBox = new PictureBox();
            borrowChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            label1 = new Label();
            completeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            statusChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1 = new MenuStrip();
            refreshF5ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bottomBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sucLogoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borrowChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)completeChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusChart).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sloganLabel
            // 
            sloganLabel.Anchor = AnchorStyles.Bottom;
            sloganLabel.AutoSize = true;
            sloganLabel.BackColor = Color.FromArgb(30, 66, 126);
            sloganLabel.Font = new Font("Microsoft Sans Serif", 40.75F, FontStyle.Bold | FontStyle.Italic);
            sloganLabel.ForeColor = SystemColors.Control;
            sloganLabel.Location = new Point(647, 949);
            sloganLabel.Name = "sloganLabel";
            sloganLabel.Size = new Size(837, 63);
            sloganLabel.TabIndex = 11;
            sloganLabel.Text = "INSPIRING GREAT LEARNING";
            // 
            // bottomBar
            // 
            bottomBar.Anchor = AnchorStyles.Bottom;
            bottomBar.BackColor = Color.FromArgb(30, 66, 126);
            bottomBar.Location = new Point(-16, 914);
            bottomBar.Name = "bottomBar";
            bottomBar.Size = new Size(1927, 352);
            bottomBar.TabIndex = 10;
            bottomBar.TabStop = false;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Arial", 51.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(720, 44);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(484, 79);
            menuLabel.TabIndex = 7;
            menuLabel.Text = "DASHBOARD";
            // 
            // sucLogoPictureBox
            // 
            sucLogoPictureBox.BackColor = SystemColors.Control;
            sucLogoPictureBox.Image = Properties.Resources.sucLogo;
            sucLogoPictureBox.Location = new Point(32, 34);
            sucLogoPictureBox.Margin = new Padding(6);
            sucLogoPictureBox.Name = "sucLogoPictureBox";
            sucLogoPictureBox.Size = new Size(200, 89);
            sucLogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            sucLogoPictureBox.TabIndex = 6;
            sucLogoPictureBox.TabStop = false;
            // 
            // returnPictureBox
            // 
            returnPictureBox.Image = Properties.Resources._return;
            returnPictureBox.Location = new Point(1749, 44);
            returnPictureBox.Name = "returnPictureBox";
            returnPictureBox.Size = new Size(92, 79);
            returnPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            returnPictureBox.TabIndex = 16;
            returnPictureBox.TabStop = false;
            returnPictureBox.Click += returnPictureBox_Click;
            // 
            // borrowChart
            // 
            borrowChart.BackColor = Color.Transparent;
            chartArea4.Name = "ChartArea1";
            borrowChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            borrowChart.Legends.Add(legend4);
            borrowChart.Location = new Point(68, 264);
            borrowChart.Name = "borrowChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            borrowChart.Series.Add(series4);
            borrowChart.Size = new Size(610, 463);
            borrowChart.TabIndex = 17;
            borrowChart.Text = "chart1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 41.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 730);
            label2.Name = "label2";
            label2.Size = new Size(438, 63);
            label2.TabIndex = 19;
            label2.Text = "Borrow Progress";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 41.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1312, 730);
            label1.Name = "label1";
            label1.Size = new Size(445, 63);
            label1.TabIndex = 21;
            label1.Text = "Complete Return";
            // 
            // completeChart
            // 
            completeChart.BackColor = Color.Transparent;
            chartArea5.Name = "ChartArea1";
            completeChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            completeChart.Legends.Add(legend5);
            completeChart.Location = new Point(1282, 264);
            completeChart.Name = "completeChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            completeChart.Series.Add(series5);
            completeChart.Size = new Size(610, 463);
            completeChart.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 41.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(859, 730);
            label3.Name = "label3";
            label3.Size = new Size(199, 63);
            label3.TabIndex = 23;
            label3.Text = "Status ";
            // 
            // statusChart
            // 
            statusChart.BackColor = Color.Transparent;
            chartArea6.Name = "ChartArea1";
            statusChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            statusChart.Legends.Add(legend6);
            statusChart.Location = new Point(684, 264);
            statusChart.Name = "statusChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            statusChart.Series.Add(series6);
            statusChart.Size = new Size(610, 463);
            statusChart.TabIndex = 22;
            statusChart.Text = "chart2";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { refreshF5ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1904, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // refreshF5ToolStripMenuItem
            // 
            refreshF5ToolStripMenuItem.Name = "refreshF5ToolStripMenuItem";
            refreshF5ToolStripMenuItem.ShortcutKeys = Keys.F5;
            refreshF5ToolStripMenuItem.Size = new Size(81, 20);
            refreshF5ToolStripMenuItem.Text = "Refresh (F5)";
            refreshF5ToolStripMenuItem.Click += refreshF5ToolStripMenuItem_Click;
            // 
            // dashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(label3);
            Controls.Add(statusChart);
            Controls.Add(label1);
            Controls.Add(completeChart);
            Controls.Add(label2);
            Controls.Add(borrowChart);
            Controls.Add(returnPictureBox);
            Controls.Add(sloganLabel);
            Controls.Add(bottomBar);
            Controls.Add(menuLabel);
            Controls.Add(sucLogoPictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "dashBoard";
            Text = "cisMenu";
            Load += cisMenu_Load;
            ((System.ComponentModel.ISupportInitialize)bottomBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)sucLogoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)borrowChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)completeChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusChart).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sloganLabel;
        private PictureBox bottomBar;
        private Label menuLabel;
        private PictureBox sucLogoPictureBox;
        private PictureBox returnPictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart borrowChart;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart completeChart;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart statusChart;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem refreshF5ToolStripMenuItem;
    }
}