namespace CloakInventorySystem
{
    partial class mainMenu
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
            cisButton = new Button();
            gmsButton = new Button();
            bottomBar = new PictureBox();
            sloganLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)sucLogoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottomBar).BeginInit();
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
            menuLabel.Location = new Point(857, 43);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(235, 79);
            menuLabel.TabIndex = 1;
            menuLabel.Text = "MENU";
            // 
            // cisButton
            // 
            cisButton.BackColor = SystemColors.ButtonShadow;
            cisButton.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cisButton.ForeColor = SystemColors.Control;
            cisButton.Location = new Point(64, 155);
            cisButton.Name = "cisButton";
            cisButton.Size = new Size(908, 759);
            cisButton.TabIndex = 2;
            cisButton.Text = "Cloak Inventory System";
            cisButton.UseVisualStyleBackColor = false;
            cisButton.Click += cisButton_Click;
            // 
            // gmsButton
            // 
            gmsButton.BackColor = SystemColors.ButtonShadow;
            gmsButton.Font = new Font("Arial", 48F, FontStyle.Bold);
            gmsButton.ForeColor = SystemColors.Control;
            gmsButton.Location = new Point(1016, 155);
            gmsButton.Name = "gmsButton";
            gmsButton.Size = new Size(852, 759);
            gmsButton.TabIndex = 3;
            gmsButton.Text = "  Graduation Management ";
            gmsButton.UseVisualStyleBackColor = false;
            gmsButton.Click += gmsButton_Click;
            // 
            // bottomBar
            // 
            bottomBar.Anchor = AnchorStyles.Bottom;
            bottomBar.BackColor = Color.Blue;
            bottomBar.Location = new Point(-9, 920);
            bottomBar.Name = "bottomBar";
            bottomBar.Size = new Size(1927, 352);
            bottomBar.TabIndex = 4;
            bottomBar.TabStop = false;
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
            sloganLabel.TabIndex = 5;
            sloganLabel.Text = "INSPIRING GREAT LEARNING";
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1904, 1041);
            Controls.Add(sloganLabel);
            Controls.Add(bottomBar);
            Controls.Add(gmsButton);
            Controls.Add(cisButton);
            Controls.Add(menuLabel);
            Controls.Add(sucLogoPictureBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "mainMenu";
            Text = "RFID Integrated Cloak Inventory and Graduation Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sucLogoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottomBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox sucLogoPictureBox;
        private Label menuLabel;
        private Button cisButton;
        private Button gmsButton;
        private PictureBox bottomBar;
        private Label sloganLabel;
    }
}
