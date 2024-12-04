namespace CloakInventorySystem
{
    partial class gmsMenu
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
            campusCIButton = new Button();
            menuLabel = new Label();
            sucLogoPictureBox = new PictureBox();
            returnPictureBox = new PictureBox();
            MPHCIbutton = new Button();
            queueButton = new Button();
            stageCIButton = new Button();
            campusCOButton = new Button();
            ceremonyScreenButton = new Button();
            stageCOButton = new Button();
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
            // campusCIButton
            // 
            campusCIButton.BackColor = SystemColors.ButtonShadow;
            campusCIButton.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            campusCIButton.ForeColor = SystemColors.Control;
            campusCIButton.Location = new Point(338, 359);
            campusCIButton.Name = "campusCIButton";
            campusCIButton.Size = new Size(380, 214);
            campusCIButton.TabIndex = 8;
            campusCIButton.Text = "Campus Check In";
            campusCIButton.UseVisualStyleBackColor = false;
            campusCIButton.Click += campusCIButton_Click;
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
            // returnPictureBox
            // 
            returnPictureBox.Image = Properties.Resources._return;
            returnPictureBox.Location = new Point(1749, 44);
            returnPictureBox.Name = "returnPictureBox";
            returnPictureBox.Size = new Size(92, 79);
            returnPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            returnPictureBox.TabIndex = 16;
            returnPictureBox.TabStop = false;
            returnPictureBox.Click += returnPictureBox_Click_1;
            // 
            // MPHCIbutton
            // 
            MPHCIbutton.BackColor = SystemColors.ButtonShadow;
            MPHCIbutton.DialogResult = DialogResult.Yes;
            MPHCIbutton.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MPHCIbutton.ForeColor = SystemColors.Control;
            MPHCIbutton.Location = new Point(752, 359);
            MPHCIbutton.Name = "MPHCIbutton";
            MPHCIbutton.Size = new Size(380, 214);
            MPHCIbutton.TabIndex = 17;
            MPHCIbutton.Text = "MPH Check In";
            MPHCIbutton.UseVisualStyleBackColor = false;
            MPHCIbutton.Click += MPHCIbutton_Click;
            // 
            // queueButton
            // 
            queueButton.BackColor = SystemColors.ButtonShadow;
            queueButton.DialogResult = DialogResult.Yes;
            queueButton.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            queueButton.ForeColor = SystemColors.Control;
            queueButton.Location = new Point(1165, 359);
            queueButton.Name = "queueButton";
            queueButton.Size = new Size(380, 214);
            queueButton.TabIndex = 18;
            queueButton.Text = "Queue Check In";
            queueButton.UseVisualStyleBackColor = false;
            // 
            // stageCIButton
            // 
            stageCIButton.BackColor = SystemColors.ButtonShadow;
            stageCIButton.DialogResult = DialogResult.Yes;
            stageCIButton.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stageCIButton.ForeColor = SystemColors.Control;
            stageCIButton.Location = new Point(338, 620);
            stageCIButton.Name = "stageCIButton";
            stageCIButton.Size = new Size(589, 104);
            stageCIButton.TabIndex = 19;
            stageCIButton.Text = "Stage Check In ";
            stageCIButton.UseVisualStyleBackColor = false;
            // 
            // campusCOButton
            // 
            campusCOButton.BackColor = SystemColors.ButtonShadow;
            campusCOButton.DialogResult = DialogResult.Yes;
            campusCOButton.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            campusCOButton.ForeColor = SystemColors.Control;
            campusCOButton.Location = new Point(338, 767);
            campusCOButton.Name = "campusCOButton";
            campusCOButton.Size = new Size(1207, 104);
            campusCOButton.TabIndex = 20;
            campusCOButton.Text = "Campus Check Out";
            campusCOButton.UseVisualStyleBackColor = false;
            // 
            // ceremonyScreenButton
            // 
            ceremonyScreenButton.BackColor = SystemColors.ButtonShadow;
            ceremonyScreenButton.DialogResult = DialogResult.Yes;
            ceremonyScreenButton.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ceremonyScreenButton.ForeColor = SystemColors.Control;
            ceremonyScreenButton.Location = new Point(338, 213);
            ceremonyScreenButton.Name = "ceremonyScreenButton";
            ceremonyScreenButton.Size = new Size(1207, 104);
            ceremonyScreenButton.TabIndex = 21;
            ceremonyScreenButton.Text = "CEREMONY SCREEN";
            ceremonyScreenButton.UseVisualStyleBackColor = false;
            // 
            // stageCOButton
            // 
            stageCOButton.BackColor = SystemColors.ButtonShadow;
            stageCOButton.DialogResult = DialogResult.Yes;
            stageCOButton.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stageCOButton.ForeColor = SystemColors.Control;
            stageCOButton.Location = new Point(965, 620);
            stageCOButton.Name = "stageCOButton";
            stageCOButton.Size = new Size(580, 104);
            stageCOButton.TabIndex = 22;
            stageCOButton.Text = "Stage Check Out";
            stageCOButton.UseVisualStyleBackColor = false;
            // 
            // gmsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(stageCOButton);
            Controls.Add(ceremonyScreenButton);
            Controls.Add(campusCOButton);
            Controls.Add(stageCIButton);
            Controls.Add(queueButton);
            Controls.Add(MPHCIbutton);
            Controls.Add(returnPictureBox);
            Controls.Add(sloganLabel);
            Controls.Add(bottomBar);
            Controls.Add(campusCIButton);
            Controls.Add(menuLabel);
            Controls.Add(sucLogoPictureBox);
            Name = "gmsMenu";
            Text = "cisMenu";
            Load += gmsMenu_Load;
            ((System.ComponentModel.ISupportInitialize)bottomBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)sucLogoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sloganLabel;
        private PictureBox bottomBar;
        private Button campusCIButton;
        private Label menuLabel;
        private PictureBox sucLogoPictureBox;
        private PictureBox returnPictureBox;
        private Button MPHCIbutton;
        private Button queueButton;
        private Button stageCIButton;
        private Button campusCOButton;
        private Button ceremonyScreenButton;
        private Button stageCOButton;
    }
}