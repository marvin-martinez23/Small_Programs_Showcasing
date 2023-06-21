namespace Small_Programs_Showcasing
{
    partial class BmiCalculator
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
            this.enteredWeight = new System.Windows.Forms.TextBox();
            this.enteredHeight = new System.Windows.Forms.TextBox();
            this.calculatedBmi = new System.Windows.Forms.TextBox();
            this.weightStatus = new System.Windows.Forms.TextBox();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.weight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enteredWeight
            // 
            this.enteredWeight.Location = new System.Drawing.Point(104, 85);
            this.enteredWeight.Name = "enteredWeight";
            this.enteredWeight.Size = new System.Drawing.Size(100, 22);
            this.enteredWeight.TabIndex = 0;
            // 
            // enteredHeight
            // 
            this.enteredHeight.Location = new System.Drawing.Point(104, 134);
            this.enteredHeight.Name = "enteredHeight";
            this.enteredHeight.Size = new System.Drawing.Size(100, 22);
            this.enteredHeight.TabIndex = 1;
            // 
            // calculatedBmi
            // 
            this.calculatedBmi.Location = new System.Drawing.Point(108, 183);
            this.calculatedBmi.Name = "calculatedBmi";
            this.calculatedBmi.ReadOnly = true;
            this.calculatedBmi.Size = new System.Drawing.Size(72, 22);
            this.calculatedBmi.TabIndex = 2;
            // 
            // weightStatus
            // 
            this.weightStatus.Location = new System.Drawing.Point(120, 240);
            this.weightStatus.Name = "weightStatus";
            this.weightStatus.ReadOnly = true;
            this.weightStatus.Size = new System.Drawing.Size(139, 22);
            this.weightStatus.TabIndex = 3;
            // 
            // calculatebutton
            // 
            this.calculatebutton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.calculatebutton.Location = new System.Drawing.Point(224, 95);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(100, 30);
            this.calculatebutton.TabIndex = 4;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(345, 51);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Enter your weight in pounds and height in inches below. \nThen click Calculate.";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(16, 85);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(71, 16);
            this.weight.TabIndex = 6;
            this.weight.Text = "Weight (lb)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height (in)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Your BMI is ...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Your status is ...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.weightStatus);
            this.Controls.Add(this.calculatedBmi);
            this.Controls.Add(this.enteredHeight);
            this.Controls.Add(this.enteredWeight);
            this.Name = "BmiCalculator";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enteredWeight;
        private System.Windows.Forms.TextBox enteredHeight;
        private System.Windows.Forms.TextBox calculatedBmi;
        private System.Windows.Forms.TextBox weightStatus;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}