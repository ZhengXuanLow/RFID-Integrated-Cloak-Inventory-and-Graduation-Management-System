namespace CloakInventorySystem
{
    partial class borrowCloak
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
            sloganLabel = new Label();
            bottomBar = new PictureBox();
            menuLabel = new Label();
            sucLogoPictureBox = new PictureBox();
            guideLabel = new Label();
            UserInputTextBox = new TextBox();
            nameLabel = new Label();
            ageLabel = new Label();
            facultyLabel = new Label();
            programLabel = new Label();
            graduateLabel = new Label();
            studentIDLabel = new Label();
            nameTextBox = new TextBox();
            studentIDTextBox = new TextBox();
            facultyTextBox = new TextBox();
            programTextBox = new TextBox();
            graduateTextBox = new TextBox();
            ageTextBox = new TextBox();
            cloakSizeTextBox = new TextBox();
            guideConfirmLabel = new Label();
            rfidGuideLabel = new Label();
            confirmRFIDLabel = new Label();
            cloakSize1Label = new Label();
            ((System.ComponentModel.ISupportInitialize)bottomBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sucLogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sloganLabel
            // 
            sloganLabel.Anchor = AnchorStyles.Bottom;
            sloganLabel.AutoSize = true;
            sloganLabel.BackColor = Color.Transparent;
            sloganLabel.Font = new Font("Arial Narrow", 40.75F, FontStyle.Bold | FontStyle.Italic);
            sloganLabel.ForeColor = SystemColors.Control;
            sloganLabel.Location = new Point(647, 949);
            sloganLabel.Name = "sloganLabel";
            sloganLabel.Size = new Size(684, 65);
            sloganLabel.TabIndex = 15;
            sloganLabel.Text = "INSPIRING GREAT LEARNING";
            // 
            // bottomBar
            // 
            bottomBar.Anchor = AnchorStyles.Bottom;
            bottomBar.BackColor = Color.Blue;
            bottomBar.Location = new Point(-16, 914);
            bottomBar.Name = "bottomBar";
            bottomBar.Size = new Size(1927, 352);
            bottomBar.TabIndex = 14;
            bottomBar.TabStop = false;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Arial", 51.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(799, 44);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(482, 79);
            menuLabel.TabIndex = 13;
            menuLabel.Text = "Borrow Claok";
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
            sucLogoPictureBox.TabIndex = 12;
            sucLogoPictureBox.TabStop = false;
            // 
            // guideLabel
            // 
            guideLabel.AutoSize = true;
            guideLabel.BorderStyle = BorderStyle.FixedSingle;
            guideLabel.Font = new Font("Arial", 50F, FontStyle.Bold | FontStyle.Italic);
            guideLabel.Location = new Point(410, 833);
            guideLabel.Name = "guideLabel";
            guideLabel.Size = new Size(1169, 78);
            guideLabel.TabIndex = 16;
            guideLabel.Text = "PLEASE SCAN THE INVITATION QR";
            // 
            // UserInputTextBox
            // 
            UserInputTextBox.Location = new Point(1792, 885);
            UserInputTextBox.Name = "UserInputTextBox";
            UserInputTextBox.Size = new Size(100, 23);
            UserInputTextBox.TabIndex = 17;
            UserInputTextBox.TextChanged += UserInputTextBox_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(283, 184);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(166, 55);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageLabel.Location = new Point(283, 372);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(123, 55);
            ageLabel.TabIndex = 19;
            ageLabel.Text = "Age:";
            // 
            // facultyLabel
            // 
            facultyLabel.AutoSize = true;
            facultyLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facultyLabel.Location = new Point(283, 465);
            facultyLabel.Name = "facultyLabel";
            facultyLabel.Size = new Size(190, 55);
            facultyLabel.TabIndex = 20;
            facultyLabel.Text = "Faculty:";
            // 
            // programLabel
            // 
            programLabel.AutoSize = true;
            programLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programLabel.Location = new Point(283, 569);
            programLabel.Name = "programLabel";
            programLabel.Size = new Size(222, 55);
            programLabel.TabIndex = 21;
            programLabel.Text = "Program:";
            // 
            // graduateLabel
            // 
            graduateLabel.AutoSize = true;
            graduateLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            graduateLabel.Location = new Point(283, 667);
            graduateLabel.Name = "graduateLabel";
            graduateLabel.Size = new Size(238, 55);
            graduateLabel.TabIndex = 22;
            graduateLabel.Text = "Graduate:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentIDLabel.Location = new Point(283, 277);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new Size(263, 55);
            studentIDLabel.TabIndex = 23;
            studentIDLabel.Text = "Student ID:";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Arial", 36F);
            nameTextBox.Location = new Point(567, 184);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(385, 63);
            nameTextBox.TabIndex = 24;
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.Font = new Font("Arial", 36F);
            studentIDTextBox.Location = new Point(567, 269);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.ReadOnly = true;
            studentIDTextBox.Size = new Size(385, 63);
            studentIDTextBox.TabIndex = 25;
            // 
            // facultyTextBox
            // 
            facultyTextBox.Font = new Font("Arial", 36F);
            facultyTextBox.Location = new Point(567, 465);
            facultyTextBox.Name = "facultyTextBox";
            facultyTextBox.ReadOnly = true;
            facultyTextBox.Size = new Size(385, 63);
            facultyTextBox.TabIndex = 26;
            // 
            // programTextBox
            // 
            programTextBox.Font = new Font("Arial", 36F);
            programTextBox.Location = new Point(567, 569);
            programTextBox.Name = "programTextBox";
            programTextBox.ReadOnly = true;
            programTextBox.Size = new Size(385, 63);
            programTextBox.TabIndex = 27;
            // 
            // graduateTextBox
            // 
            graduateTextBox.Font = new Font("Arial", 36F);
            graduateTextBox.Location = new Point(567, 664);
            graduateTextBox.Name = "graduateTextBox";
            graduateTextBox.ReadOnly = true;
            graduateTextBox.Size = new Size(385, 63);
            graduateTextBox.TabIndex = 28;
            // 
            // ageTextBox
            // 
            ageTextBox.Font = new Font("Arial", 36F);
            ageTextBox.Location = new Point(567, 372);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.ReadOnly = true;
            ageTextBox.Size = new Size(385, 63);
            ageTextBox.TabIndex = 29;
            // 
            // cloakSizeTextBox
            // 
            cloakSizeTextBox.Font = new Font("Arial", 36F);
            cloakSizeTextBox.Location = new Point(1319, 187);
            cloakSizeTextBox.Name = "cloakSizeTextBox";
            cloakSizeTextBox.ReadOnly = true;
            cloakSizeTextBox.Size = new Size(385, 63);
            cloakSizeTextBox.TabIndex = 31;
            cloakSizeTextBox.Visible = false;
            // 
            // guideConfirmLabel
            // 
            guideConfirmLabel.AutoSize = true;
            guideConfirmLabel.BorderStyle = BorderStyle.FixedSingle;
            guideConfirmLabel.Font = new Font("Arial", 30F, FontStyle.Bold | FontStyle.Italic);
            guideConfirmLabel.Location = new Point(373, 846);
            guideConfirmLabel.Name = "guideConfirmLabel";
            guideConfirmLabel.Size = new Size(1347, 48);
            guideConfirmLabel.TabIndex = 32;
            guideConfirmLabel.Text = "PLEASE CONFIRM THE INFORMATION BY SCANNING THE QR AGAIN";
            guideConfirmLabel.Visible = false;
            // 
            // rfidGuideLabel
            // 
            rfidGuideLabel.AutoEllipsis = true;
            rfidGuideLabel.AutoSize = true;
            rfidGuideLabel.BorderStyle = BorderStyle.FixedSingle;
            rfidGuideLabel.Font = new Font("Arial", 30F, FontStyle.Bold | FontStyle.Italic);
            rfidGuideLabel.Location = new Point(502, 846);
            rfidGuideLabel.Name = "rfidGuideLabel";
            rfidGuideLabel.Size = new Size(1000, 48);
            rfidGuideLabel.TabIndex = 33;
            rfidGuideLabel.Text = "PLEASE PLACE THE CLOAK NEAR THE SCANNER";
            rfidGuideLabel.Visible = false;
            // 
            // confirmRFIDLabel
            // 
            confirmRFIDLabel.AutoSize = true;
            confirmRFIDLabel.BorderStyle = BorderStyle.FixedSingle;
            confirmRFIDLabel.Font = new Font("Arial", 30F, FontStyle.Bold | FontStyle.Italic);
            confirmRFIDLabel.Location = new Point(324, 846);
            confirmRFIDLabel.Name = "confirmRFIDLabel";
            confirmRFIDLabel.Size = new Size(1429, 48);
            confirmRFIDLabel.TabIndex = 34;
            confirmRFIDLabel.Text = "PLEASE CONFIRM THE INFORMATION BY SCANNING THE CLOAK AGAIN";
            confirmRFIDLabel.Visible = false;
            // 
            // cloakSize1Label
            // 
            cloakSize1Label.AutoSize = true;
            cloakSize1Label.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cloakSize1Label.Location = new Point(1027, 192);
            cloakSize1Label.Name = "cloakSize1Label";
            cloakSize1Label.Size = new Size(266, 55);
            cloakSize1Label.TabIndex = 35;
            cloakSize1Label.Text = "Cloak Size:";
            cloakSize1Label.Visible = false;
            // 
            // borrowCloak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(cloakSize1Label);
            Controls.Add(confirmRFIDLabel);
            Controls.Add(rfidGuideLabel);
            Controls.Add(guideConfirmLabel);
            Controls.Add(cloakSizeTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(graduateTextBox);
            Controls.Add(programTextBox);
            Controls.Add(facultyTextBox);
            Controls.Add(studentIDTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(studentIDLabel);
            Controls.Add(graduateLabel);
            Controls.Add(programLabel);
            Controls.Add(facultyLabel);
            Controls.Add(ageLabel);
            Controls.Add(nameLabel);
            Controls.Add(UserInputTextBox);
            Controls.Add(guideLabel);
            Controls.Add(sloganLabel);
            Controls.Add(bottomBar);
            Controls.Add(menuLabel);
            Controls.Add(sucLogoPictureBox);
            Name = "borrowCloak";
            Text = "borrowScanQR";
            Load += borrowCloak_Load;
            ((System.ComponentModel.ISupportInitialize)bottomBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)sucLogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sloganLabel;
        private PictureBox bottomBar;
        private Label menuLabel;
        private PictureBox sucLogoPictureBox;
        private Label guideLabel;
        private TextBox UserInputTextBox;
        private Label nameLabel;
        private Label ageLabel;
        private Label facultyLabel;
        private Label programLabel;
        private Label graduateLabel;
        private Label studentIDLabel;
        private TextBox nameTextBox;
        private TextBox studentIDTextBox;
        private TextBox facultyTextBox;
        private TextBox programTextBox;
        private TextBox graduateTextBox;
        private TextBox ageTextBox;
        private TextBox cloakSizeTextBox;
        private Label cloakSizeLabel;
        private Label guideConfirmLabel;
        private Label rfidGuideLabel;
        private Label confirmRFIDLabel;
        private Label cloakSize1Label;
    }
}