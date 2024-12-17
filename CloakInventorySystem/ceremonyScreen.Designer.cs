namespace CloakInventorySystem
{
    partial class ceremonyScreen
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
            nameLabel = new Label();
            facultyLabel = new Label();
            courseLabel = new Label();
            graduationLabel = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Right;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Microsoft Sans Serif", 80.25F);
            nameLabel.ForeColor = SystemColors.Control;
            nameLabel.Location = new Point(693, 297);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(1199, 120);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // facultyLabel
            // 
            facultyLabel.Anchor = AnchorStyles.Right;
            facultyLabel.BackColor = Color.Transparent;
            facultyLabel.Font = new Font("Microsoft Sans Serif", 30.25F);
            facultyLabel.ForeColor = SystemColors.Control;
            facultyLabel.Location = new Point(675, 428);
            facultyLabel.Name = "facultyLabel";
            facultyLabel.Size = new Size(1217, 113);
            facultyLabel.TabIndex = 7;
            facultyLabel.Text = "Faculty";
            facultyLabel.TextAlign = ContentAlignment.MiddleRight;

            // 
            // courseLabel
            // 
            courseLabel.BackColor = Color.Transparent;
            courseLabel.Font = new Font("Microsoft Sans Serif", 30.25F);
            courseLabel.ForeColor = SystemColors.Control;
            courseLabel.Location = new Point(693, 541);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new Size(1199, 92);
            courseLabel.TabIndex = 8;
            courseLabel.Text = "Subject";
            courseLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // graduationLabel
            // 
            graduationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            graduationLabel.BackColor = Color.Transparent;
            graduationLabel.Font = new Font("Microsoft Sans Serif", 41.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            graduationLabel.ForeColor = SystemColors.Control;
            graduationLabel.Location = new Point(693, 656);
            graduationLabel.Name = "graduationLabel";
            graduationLabel.Size = new Size(1199, 63);
            graduationLabel.TabIndex = 9;
            graduationLabel.Text = "Graduation Speech";
            graduationLabel.TextAlign = ContentAlignment.MiddleRight;
 
            // 
            // ceremonyScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources._7be8762b341fe0a64ba424805b1d70e31f8b22f3_s2_n2_y1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(graduationLabel);
            Controls.Add(courseLabel);
            Controls.Add(facultyLabel);
            Controls.Add(nameLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ceremonyScreen";
            Text = "RFID Integrated Cloak Inventory and Graduation Management System";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label nameLabel;
        private Label facultyLabel;
        private Label courseLabel;
        private Label graduationLabel;
    }
}
