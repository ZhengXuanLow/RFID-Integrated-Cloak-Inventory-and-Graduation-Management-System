namespace CloakInventorySystem
{
    partial class dataListView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sucLogoPictureBox = new PictureBox();
            menuLabel = new Label();
            bottomBar = new PictureBox();
            dataGridView = new DataGridView();
            returnPictureBox = new PictureBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            ICTextBox = new TextBox();
            label1 = new Label();
            rfidTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            statusComboBox = new ComboBox();
            label4 = new Label();
            updateButton = new Button();
            speechrichTextBox = new RichTextBox();
            searchStudentIDTextBox = new TextBox();
            searchRFIDTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            refreshF5ToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem1 = new ToolStripMenuItem();
            deleteAllToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)sucLogoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottomBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnPictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            sucLogoPictureBox.TabIndex = 0;
            sucLogoPictureBox.TabStop = false;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Arial", 51.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(774, 44);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(497, 79);
            menuLabel.TabIndex = 1;
            menuLabel.Text = "Data List View";
            // 
            // bottomBar
            // 
            bottomBar.Anchor = AnchorStyles.Bottom;
            bottomBar.BackColor = Color.FromArgb(30, 66, 126);
            bottomBar.Location = new Point(-9, 676);
            bottomBar.Name = "bottomBar";
            bottomBar.Size = new Size(1927, 596);
            bottomBar.TabIndex = 4;
            bottomBar.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(98, 198);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(1703, 446);
            dataGridView.TabIndex = 6;
            // 
            // returnPictureBox
            // 
            returnPictureBox.Image = Properties.Resources._return;
            returnPictureBox.Location = new Point(1786, 44);
            returnPictureBox.Name = "returnPictureBox";
            returnPictureBox.Size = new Size(92, 79);
            returnPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            returnPictureBox.TabIndex = 41;
            returnPictureBox.TabStop = false;
            returnPictureBox.Click += returnPictureBox_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.FromArgb(30, 66, 126);
            nameLabel.Font = new Font("Arial", 30F);
            nameLabel.ForeColor = SystemColors.Control;
            nameLabel.Location = new Point(98, 735);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(138, 45);
            nameLabel.TabIndex = 43;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(30, 66, 126);
            nameTextBox.Font = new Font("Arial", 30F);
            nameTextBox.ForeColor = SystemColors.Control;
            nameTextBox.Location = new Point(429, 735);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(296, 53);
            nameTextBox.TabIndex = 44;
            // 
            // ICTextBox
            // 
            ICTextBox.BackColor = Color.FromArgb(30, 66, 126);
            ICTextBox.Font = new Font("Arial", 30F);
            ICTextBox.ForeColor = SystemColors.Control;
            ICTextBox.Location = new Point(429, 835);
            ICTextBox.Name = "ICTextBox";
            ICTextBox.Size = new Size(296, 53);
            ICTextBox.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(30, 66, 126);
            label1.Font = new Font("Arial", 30F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(98, 838);
            label1.Name = "label1";
            label1.Size = new Size(279, 45);
            label1.TabIndex = 45;
            label1.Text = "InvitationCode:";
            // 
            // rfidTextBox
            // 
            rfidTextBox.BackColor = Color.FromArgb(30, 66, 126);
            rfidTextBox.Font = new Font("Arial", 30F);
            rfidTextBox.ForeColor = SystemColors.Control;
            rfidTextBox.Location = new Point(1035, 738);
            rfidTextBox.Name = "rfidTextBox";
            rfidTextBox.Size = new Size(278, 53);
            rfidTextBox.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 66, 126);
            label2.Font = new Font("Arial", 30F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(766, 741);
            label2.Name = "label2";
            label2.Size = new Size(125, 45);
            label2.TabIndex = 47;
            label2.Text = "rfidID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 66, 126);
            label3.Font = new Font("Arial", 30F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(766, 841);
            label3.Name = "label3";
            label3.Size = new Size(263, 45);
            label3.TabIndex = 49;
            label3.Text = "currentStatus:";
            // 
            // statusComboBox
            // 
            statusComboBox.BackColor = Color.FromArgb(30, 66, 126);
            statusComboBox.Font = new Font("Arial", 30F);
            statusComboBox.ForeColor = SystemColors.Control;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "1. Before Borrow", "2. Done Borrow", "3. Check In SUC", "4. MPH Check In", "5. Queueing", "6. On Stage", "7. Off Stage", "8. Return" });
            statusComboBox.Location = new Point(1035, 841);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(278, 53);
            statusComboBox.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 66, 126);
            label4.Font = new Font("Arial", 30F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(1358, 741);
            label4.Name = "label4";
            label4.Size = new Size(369, 45);
            label4.TabIndex = 52;
            label4.Text = "Graduation Speech:";
            // 
            // updateButton
            // 
            updateButton.BackColor = SystemColors.ControlLight;
            updateButton.Font = new Font("Arial", 30F);
            updateButton.Location = new Point(1358, 975);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(458, 54);
            updateButton.TabIndex = 54;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // speechrichTextBox
            // 
            speechrichTextBox.BackColor = Color.FromArgb(30, 66, 126);
            speechrichTextBox.Font = new Font("Arial", 12F);
            speechrichTextBox.ForeColor = SystemColors.Control;
            speechrichTextBox.Location = new Point(1358, 795);
            speechrichTextBox.Name = "speechrichTextBox";
            speechrichTextBox.Size = new Size(458, 174);
            speechrichTextBox.TabIndex = 55;
            speechrichTextBox.Text = "";
            // 
            // searchStudentIDTextBox
            // 
            searchStudentIDTextBox.Location = new Point(98, 156);
            searchStudentIDTextBox.Name = "searchStudentIDTextBox";
            searchStudentIDTextBox.PlaceholderText = "🔎 Search (Student ID)";
            searchStudentIDTextBox.Size = new Size(846, 23);
            searchStudentIDTextBox.TabIndex = 56;
            searchStudentIDTextBox.TextChanged += searchStudentIDTextBox_TextChanged;
            // 
            // searchRFIDTextBox
            // 
            searchRFIDTextBox.Location = new Point(955, 156);
            searchRFIDTextBox.Name = "searchRFIDTextBox";
            searchRFIDTextBox.PlaceholderText = "🔎 Search (RFIDID)";
            searchRFIDTextBox.Size = new Size(846, 23);
            searchRFIDTextBox.TabIndex = 58;
            searchRFIDTextBox.TextChanged += searchRFIDTextBox_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { refreshF5ToolStripMenuItem, importToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1904, 24);
            menuStrip1.TabIndex = 59;
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
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem1, deleteAllToolStripMenuItem });
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(56, 20);
            importToolStripMenuItem.Text = "Option";
            // 
            // importToolStripMenuItem1
            // 
            importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            importToolStripMenuItem1.Size = new Size(180, 22);
            importToolStripMenuItem1.Text = "Import";
            importToolStripMenuItem1.Click += importToolStripMenuItem1_Click;
            // 
            // deleteAllToolStripMenuItem
            // 
            deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            deleteAllToolStripMenuItem.Size = new Size(180, 22);
            deleteAllToolStripMenuItem.Text = "Delete All";
            deleteAllToolStripMenuItem.Click += deleteAllToolStripMenuItem_Click;
            // 
            // dataListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1904, 1041);
            Controls.Add(searchRFIDTextBox);
            Controls.Add(searchStudentIDTextBox);
            Controls.Add(speechrichTextBox);
            Controls.Add(updateButton);
            Controls.Add(label4);
            Controls.Add(statusComboBox);
            Controls.Add(label3);
            Controls.Add(rfidTextBox);
            Controls.Add(label2);
            Controls.Add(ICTextBox);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(returnPictureBox);
            Controls.Add(dataGridView);
            Controls.Add(bottomBar);
            Controls.Add(menuLabel);
            Controls.Add(sucLogoPictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "dataListView";
            Text = "RFID Integrated Cloak Inventory and Graduation Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sucLogoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottomBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnPictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox sucLogoPictureBox;
        private Label menuLabel;
        private PictureBox bottomBar;
        private DataGridView dataGridView;
        private PictureBox returnPictureBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox ICTextBox;
        private Label label1;
        private TextBox rfidTextBox;
        private Label label2;
        private Label label3;
        private ComboBox statusComboBox;
        private Label label4;
        private Button updateButton;
        private RichTextBox speechrichTextBox;
        private TextBox searchStudentIDTextBox;
        private TextBox searchRFIDTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem1;
        private ToolStripMenuItem deleteAllToolStripMenuItem;
        private ToolStripMenuItem refreshF5ToolStripMenuItem;
    }
}
