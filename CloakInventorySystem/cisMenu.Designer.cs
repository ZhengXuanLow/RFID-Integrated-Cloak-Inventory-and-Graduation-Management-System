namespace CloakInventorySystem
{
    partial class cisMenu
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
            borrowButton = new Button();
            menuLabel = new Label();
            sucLogoPictureBox = new PictureBox();
            returnButton = new Button();
            studentDLVButton = new Button();
            cloakDLVButton = new Button();
            dashboardButton = new Button();
            returnPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bottomBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sucLogoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnPictureBox).BeginInit();
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
            sloganLabel.TabIndex = 11;
            sloganLabel.Text = "INSPIRING GREAT LEARNING";
            // 
            // bottomBar
            // 
            bottomBar.Anchor = AnchorStyles.Bottom;
            bottomBar.BackColor = Color.Blue;
            bottomBar.Location = new Point(-16, 914);
            bottomBar.Name = "bottomBar";
            bottomBar.Size = new Size(1927, 352);
            bottomBar.TabIndex = 10;
            bottomBar.TabStop = false;
            // 
            // borrowButton
            // 
            borrowButton.BackColor = SystemColors.ButtonShadow;
            borrowButton.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowButton.ForeColor = SystemColors.Control;
            borrowButton.Location = new Point(359, 270);
            borrowButton.Name = "borrowButton";
            borrowButton.Size = new Size(570, 316);
            borrowButton.TabIndex = 8;
            borrowButton.Text = "Borrow Cloak";
            borrowButton.UseVisualStyleBackColor = false;
            borrowButton.Click += borrowButton_Click;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Arial", 51.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(448, 44);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(998, 79);
            menuLabel.TabIndex = 7;
            menuLabel.Text = "CLOAK INVENTORY SYSTEM";
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
            // returnButton
            // 
            returnButton.BackColor = SystemColors.ButtonShadow;
            returnButton.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnButton.ForeColor = SystemColors.Control;
            returnButton.Location = new Point(973, 270);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(570, 316);
            returnButton.TabIndex = 12;
            returnButton.Text = "Return Cloak";
            returnButton.UseVisualStyleBackColor = false;
            // 
            // studentDLVButton
            // 
            studentDLVButton.BackColor = SystemColors.ButtonShadow;
            studentDLVButton.Font = new Font("Arial", 32F, FontStyle.Bold);
            studentDLVButton.ForeColor = SystemColors.Control;
            studentDLVButton.Location = new Point(220, 630);
            studentDLVButton.Name = "studentDLVButton";
            studentDLVButton.Size = new Size(462, 226);
            studentDLVButton.TabIndex = 13;
            studentDLVButton.Text = "Student Data List View";
            studentDLVButton.UseVisualStyleBackColor = false;
            // 
            // cloakDLVButton
            // 
            cloakDLVButton.BackColor = SystemColors.ButtonShadow;
            cloakDLVButton.Font = new Font("Arial", 32F, FontStyle.Bold);
            cloakDLVButton.ForeColor = SystemColors.Control;
            cloakDLVButton.Location = new Point(713, 630);
            cloakDLVButton.Name = "cloakDLVButton";
            cloakDLVButton.Size = new Size(462, 226);
            cloakDLVButton.TabIndex = 14;
            cloakDLVButton.Text = "Cloak Data List View";
            cloakDLVButton.UseVisualStyleBackColor = false;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = SystemColors.ButtonShadow;
            dashboardButton.Font = new Font("Arial", 32F, FontStyle.Bold);
            dashboardButton.ForeColor = SystemColors.Control;
            dashboardButton.Location = new Point(1207, 630);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(462, 226);
            dashboardButton.TabIndex = 15;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = false;
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
            // cisMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(returnPictureBox);
            Controls.Add(dashboardButton);
            Controls.Add(cloakDLVButton);
            Controls.Add(studentDLVButton);
            Controls.Add(returnButton);
            Controls.Add(sloganLabel);
            Controls.Add(bottomBar);
            Controls.Add(borrowButton);
            Controls.Add(menuLabel);
            Controls.Add(sucLogoPictureBox);
            Name = "cisMenu";
            Text = "cisMenu";
            Load += cisMenu_Load;
            ((System.ComponentModel.ISupportInitialize)bottomBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)sucLogoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sloganLabel;
        private PictureBox bottomBar;
        private Button borrowButton;
        private Label menuLabel;
        private PictureBox sucLogoPictureBox;
        private Button returnButton;
        private Button studentDLVButton;
        private Button cloakDLVButton;
        private Button dashboardButton;
        private PictureBox returnPictureBox;
    }
}