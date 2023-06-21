using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Programs_Showcasing
{
    public partial class Password_Generator : Form
    {
        public Password_Generator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_Generator_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home home = new Home();
            home.Show();
        }


        private string fileContent;

        private void browseButton_Click(object sender, EventArgs e)
        {
            //open file and give directory
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\temp";
            openFileDialog.Filter = "txt files(*.txt)|*.txt|All files (*.*|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                fileContent = File.ReadAllText(selectedFilePath);
                fileName.Text = selectedFilePath;
                
            }

        }

        
        private void numbOfPw_TextChanged(object sender, EventArgs e)
        {
            //double check that only numbers are entered 
            if (double.TryParse(numbOfPw.Text, out double numberOfPws))
            {
                numbOfPw.Text = numberOfPws.ToString();


            }
            else
            {
                MessageBox.Show("Please enter a number!");
            }
        }

        private List<string> words;
        private void pwGenButton_Click(object sender, EventArgs e)
        {

            //check for file and load if it exist.
            if (File.Exists(fileName.Text))
            {
                List<string> words = new List<string>();
                using (StreamReader sr = new StreamReader(fileName.Text))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine().Trim();
                        if (line != "")
                        {
                            //parsing the words
                            string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
                            words.AddRange(parts);
                            string password = GeneratePw(words);

                             pwCreated.Text = password;
                        }
                    }
                }
              
            }
            else
            {
                MessageBox.Show("I'm sorry, but that file does not exist.");
            }
        }

        private string GeneratePw(List<string> words)
        {
            int numberOfPwToGenerate = int.Parse(numbOfPw.Text);
            int wordCount = words.Count;
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();

            
            for (int i = 0; i < numberOfPwToGenerate; i++) 
            {
                int randomIndex = random.Next(wordCount);
                stringBuilder.Append(words[randomIndex]);
            }
            return stringBuilder.ToString();
        }
    }
}

