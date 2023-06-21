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
    public partial class BmiCalculator : Form
    {
        public BmiCalculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home home = new Home();
            home.Show();
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            //Check that the input is numeric
            if (double.TryParse(enteredWeight.Text, out double weight) && double.TryParse(enteredHeight.Text, out double height))
            { 
                //convert from string to doubles
                string weightEntered = enteredWeight.Text;
                double convertedWeight = Convert.ToDouble(weightEntered);

                string heightEntered = enteredHeight.Text;
                double convertedHeight = Convert.ToDouble(heightEntered);

                double meters = convertedHeight * 0.0254;
                double kilos = convertedWeight * 0.45359237;

                //calculations
                double calcdBmi = kilos / (meters * meters);

                calculatedBmi.Text = string.Format($"{calcdBmi:00.##}");

                string status;
                if (calcdBmi < 18.5)
                {
                    status = " underweight";
                }
                else if (calcdBmi < 25)
                {
                    status = " normal weight";
                }
                else if (calcdBmi < 30)
                {
                    status = " overweight";
                }
                else
                {
                    status = " obese";
                }

                weightStatus.Text = status;
            }
            else
            {

                MessageBox.Show("The mass and height must be numbers.");
            }

        }
    }
}
