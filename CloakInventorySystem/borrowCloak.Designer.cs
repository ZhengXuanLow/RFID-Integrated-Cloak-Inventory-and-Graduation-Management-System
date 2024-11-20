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
            cloakSizeLabel = new Label();
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
            nameTextBox.Size = new Size(385, 63);
            nameTextBox.TabIndex = 24;
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.Font = new Font("Arial", 36F);
            studentIDTextBox.Location = new Point(567, 269);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.Size = new Size(385, 63);
            studentIDTextBox.TabIndex = 25;
            // 
            // facultyTextBox
            // 
            facultyTextBox.Font = new Font("Arial", 36F);
            facultyTextBox.Location = new Point(567, 465);
            facultyTextBox.Name = "facultyTextBox";
            facultyTextBox.Size = new Size(385, 63);
            facultyTextBox.TabIndex = 26;
            // 
            // programTextBox
            // 
            programTextBox.Font = new Font("Arial", 36F);
            programTextBox.Location = new Point(567, 569);
            programTextBox.Name = "programTextBox";
            programTextBox.Size = new Size(385, 63);
            programTextBox.TabIndex = 27;
            // 
            // graduateTextBox
            // 
            graduateTextBox.Font = new Font("Arial", 36F);
            graduateTextBox.Location = new Point(567, 664);
            graduateTextBox.Name = "graduateTextBox";
            graduateTextBox.Size = new Size(385, 63);
            graduateTextBox.TabIndex = 28;
            // 
            // ageTextBox
            // 
            ageTextBox.Font = new Font("Arial", 36F);
            ageTextBox.Location = new Point(567, 372);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(385, 63);
            ageTextBox.TabIndex = 29;
            // 
            // cloakSizeTextBox
            // 
            cloakSizeTextBox.Font = new Font("Arial", 36F);
            cloakSizeTextBox.Location = new Point(1319, 187);
            cloakSizeTextBox.Name = "cloakSizeTextBox";
            cloakSizeTextBox.Size = new Size(385, 63);
            cloakSizeTextBox.TabIndex = 31;
            // 
            // cloakSizeLabel
            // 
            cloakSizeLabel.AutoSize = true;
            cloakSizeLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cloakSizeLabel.Location = new Point(1035, 187);
            cloakSizeLabel.Name = "cloakSizeLabel";
            cloakSizeLabel.Size = new Size(266, 55);
            cloakSizeLabel.TabIndex = 30;
            cloakSizeLabel.Text = "Cloak Size:";
            // 
            // borrowCloak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(cloakSizeTextBox);
            Controls.Add(cloakSizeLabel);
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
    }
}