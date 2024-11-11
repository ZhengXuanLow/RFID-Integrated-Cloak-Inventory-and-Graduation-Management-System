namespace CloakInventorySystem
{
    partial class Form1
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
            RFIDtextbox = new TextBox();
            StudentIDTextBox = new TextBox();
            StudentNameTextBox = new TextBox();
            courseTextBox = new TextBox();
            DepartmentNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // RFIDtextbox
            // 
            RFIDtextbox.Location = new Point(590, 411);
            RFIDtextbox.Name = "RFIDtextbox";
            RFIDtextbox.Size = new Size(198, 27);
            RFIDtextbox.TabIndex = 0;
            RFIDtextbox.TextChanged += RFIDtextbox_TextChanged;
            // 
            // StudentIDTextBox
            // 
            StudentIDTextBox.Location = new Point(104, 96);
            StudentIDTextBox.Name = "StudentIDTextBox";
            StudentIDTextBox.Size = new Size(383, 27);
            StudentIDTextBox.TabIndex = 1;
            // 
            // StudentNameTextBox
            // 
            StudentNameTextBox.Location = new Point(104, 156);
            StudentNameTextBox.Name = "StudentNameTextBox";
            StudentNameTextBox.Size = new Size(383, 27);
            StudentNameTextBox.TabIndex = 2;
            // 
            // courseTextBox
            // 
            courseTextBox.Location = new Point(104, 222);
            courseTextBox.Name = "courseTextBox";
            courseTextBox.Size = new Size(383, 27);
            courseTextBox.TabIndex = 3;
            // 
            // DepartmentNameTextBox
            // 
            DepartmentNameTextBox.Location = new Point(104, 284);
            DepartmentNameTextBox.Name = "DepartmentNameTextBox";
            DepartmentNameTextBox.Size = new Size(383, 27);
            DepartmentNameTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DepartmentNameTextBox);
            Controls.Add(courseTextBox);
            Controls.Add(StudentNameTextBox);
            Controls.Add(StudentIDTextBox);
            Controls.Add(RFIDtextbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RFIDtextbox;
        private TextBox StudentIDTextBox;
        private TextBox StudentNameTextBox;
        private TextBox courseTextBox;
        private TextBox DepartmentNameTextBox;
    }
}
