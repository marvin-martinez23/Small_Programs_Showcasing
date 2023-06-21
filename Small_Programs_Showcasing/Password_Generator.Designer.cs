namespace Small_Programs_Showcasing
{
    partial class Password_Generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.pwGenButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pwCreated = new System.Windows.Forms.RichTextBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.numbOfPw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter name of file:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "# of passwords:";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(391, 41);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(104, 26);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pwGenButton
            // 
            this.pwGenButton.Location = new System.Drawing.Point(283, 87);
            this.pwGenButton.Name = "pwGenButton";
            this.pwGenButton.Size = new System.Drawing.Size(194, 29);
            this.pwGenButton.TabIndex = 3;
            this.pwGenButton.Text = "Generate";
            this.pwGenButton.UseVisualStyleBackColor = true;
            this.pwGenButton.Click += new System.EventHandler(this.pwGenButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(344, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pwCreated
            // 
            this.pwCreated.Location = new System.Drawing.Point(31, 132);
            this.pwCreated.Name = "pwCreated";
            this.pwCreated.ReadOnly = true;
            this.pwCreated.Size = new System.Drawing.Size(285, 288);
            this.pwCreated.TabIndex = 6;
            this.pwCreated.Text = "";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(157, 41);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(228, 22);
            this.fileName.TabIndex = 7;
            // 
            // numbOfPw
            // 
            this.numbOfPw.Location = new System.Drawing.Point(157, 90);
            this.numbOfPw.Name = "numbOfPw";
            this.numbOfPw.Size = new System.Drawing.Size(120, 22);
            this.numbOfPw.TabIndex = 8;
            this.numbOfPw.TextChanged += new System.EventHandler(this.numbOfPw_TextChanged);
            // 
            // Password_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 432);
            this.Controls.Add(this.numbOfPw);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.pwCreated);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pwGenButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Password_Generator";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Password_Generator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button pwGenButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox pwCreated;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.TextBox numbOfPw;
    }
}