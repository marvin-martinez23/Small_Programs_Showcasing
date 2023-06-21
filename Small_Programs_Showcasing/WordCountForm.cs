using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Programs_Showcasing
{
    public partial class WordCountForm : Form
    {
        private Dictionary<string, int> frequencies;
        public WordCountForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home home = new Home();
            home.Show();
        }


       
        private void storyEntered_TextChanged(object sender, EventArgs e)
        {
            /*load the text entered and remove the periods and commas
             * so when counted the ones with periods are not counted seperately
            */
            string storyToCount = storyEntered.Text;
            storyToCount = storyToCount.Replace(",", "").Replace(".", "");

            //initialize dic for access at action button
            frequencies = new Dictionary<string, int>();

            if (storyToCount != "")
            {
                string[] parts = storyToCount.Split(' ');
                foreach (string part in parts)
                {
                    if (frequencies.ContainsKey(part))
                    {
                        frequencies[part]++;
                    }
                    else
                    {
                        frequencies.Add(part, 1);
                    }
                }
            }
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
         List<string> words = new List<string>();
            foreach (var entry in frequencies)
            {
                words.Add($"{entry.Key} {entry.Value}");


            }
            words.Sort();
            //clear the box
            richTextBox2.Clear();

            richTextBox2.AppendText(string.Join(Environment.NewLine, words));
        }
    }
}



