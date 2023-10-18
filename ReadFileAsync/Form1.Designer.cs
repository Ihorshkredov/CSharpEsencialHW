namespace ReadFileAsync
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
            btnOpen = new Button();
            txtBoxPath = new TextBox();
            btnRead = new Button();
            txtBoxFileText = new TextBox();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(651, 36);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(80, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Browse";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // txtBoxPath
            // 
            txtBoxPath.Location = new Point(106, 36);
            txtBoxPath.Name = "txtBoxPath";
            txtBoxPath.Size = new Size(514, 23);
            txtBoxPath.TabIndex = 1;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(762, 35);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // txtBoxFileText
            // 
            txtBoxFileText.Location = new Point(35, 127);
            txtBoxFileText.Multiline = true;
            txtBoxFileText.Name = "txtBoxFileText";
            txtBoxFileText.ScrollBars = ScrollBars.Vertical;
            txtBoxFileText.Size = new Size(867, 372);
            txtBoxFileText.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 549);
            Controls.Add(txtBoxFileText);
            Controls.Add(btnRead);
            Controls.Add(txtBoxPath);
            Controls.Add(btnOpen);
            Name = "Form1";
            Text = "File_open";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private TextBox txtBoxPath;
        private Button btnRead;
        private TextBox txtBoxFileText;
    }
}