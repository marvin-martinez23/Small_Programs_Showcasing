using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Programs_Showcasing
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hometxtbox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("\"Small Programs ShowCase\" by Marvin Martinez \nfor CPSC 23000 Summer 2023");
        }

        private void bMICalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance 
            BmiCalculator form2 = new BmiCalculator();

            // Show the target form
            form2.Show();

            // Hide 
            this.Hide();
        }

        private void passwordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance 
            Password_Generator password_Generator = new Password_Generator();

            // Show 
            password_Generator.Show();

            // Hide 
            this.Hide();
        }

        private void wordCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance
            WordCountForm wordCountForm = new WordCountForm();

            // Show 
            wordCountForm.Show();

            // Hide 
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Small Programs ShowCase\" by Marvin Martinez \nfor CPSC 23000 Summer 2023");
        }
    }
    
}
