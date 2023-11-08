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

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void tempConversion_Click(object sender, EventArgs e)
        {
            string inputText = txtInput1.Text;
            string inputText1 = txtInput2.Text;

            if (rdoTempConverter1.Checked)
            {
                if (int.TryParse(inputText, out int conversion))
                {
                    double fahrenheit = (conversion * 9 / 5) + 32;
                    rtbOutput.Text += ($"{conversion} degrees Celsius is {fahrenheit} degrees Fahrenheit");

                }
                else
                {
                    rtbOutput.Text += "Invalid input. Please enter a valid number for Celsius temperature.";
                }

                if (int.TryParse(inputText1, out int conversion1))
                {
                    double fahrenheit = (conversion1 * 9 / 5) + 32;
                    rtbOutput.Text += ($" \n{conversion1} degrees Celsius is {fahrenheit} degrees Fahrenheit");

                }
                else
                {
                    rtbOutput.Text += "\n Invalid input. Please enter a valid number for Celsius temperature.";
                }


            }
            else if (rdoTempConverter2.Checked)
            {
                if (int.TryParse(inputText, out int conversion))
                {
                    double celsuis = (conversion - 32) * 5 / 9;
                    rtbOutput.Text += ($" {conversion} degrees Fahrenhiet is {celsuis} celsuis");
                }
                else
                {
                    rtbOutput.Text += "Invalid input. Please enter a valid number for Celsius temperature.";
                }
                if (int.TryParse(inputText1, out int conversion1))
                {
                    double celsuis = (conversion1 - 32) * 5 / 9;
                    rtbOutput.Text += ($" \n {conversion1} degrees Fahrenhiet is {celsuis} celsuis");
                }
                else
                {
                    rtbOutput.Text += "\n Invalid input. Please enter a valid number for Celsius temperature.";
                }
            }

        }

        private void cmbMoneyConverter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void moneyConversion_Click(object sender, EventArgs e)
        {
            string input1 = txtInput1.Text;
            if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar - Yen")
            {
                rtbOutput.Text += float.Parse(input1) * 149.78;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Yen - Dollar")
            {
                rtbOutput.Text += float.Parse(input1) * .0067;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar - UGX")
            {
                rtbOutput.Text += float.Parse(input1) * 3763.81;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "UGX - Dollar")
            {
                rtbOutput.Text += float.Parse(input1) * 0.00027;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar - KES")
            {
                rtbOutput.Text += float.Parse(input1) * 151.21;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "KES - Dollar")
            {
                rtbOutput.Text += float.Parse(input1) * 0.0066;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar - EUR")
            {
                rtbOutput.Text += float.Parse(input1) * .93;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "EUR - Dollar")
            {
                rtbOutput.Text += float.Parse(input1) * 1.07;

            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar - GBP")
            {
                rtbOutput.Text += float.Parse(input1) * .81;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "GBP - Dollar")
            {
                rtbOutput.Text += float.Parse(input1) * 1.24;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inputText = txtInput1.Text;
            if (chkMileToKilo.Checked)
            {
                if (int.TryParse(inputText, out int conversion))
                { 
                    double kilometers = conversion * 1.60934;
                    rtbOutput.Text += ($"{conversion} miles is {kilometers} kilometers");

                }
            }
            else if (chkMeterToInch.Checked)
            {
                if (int.TryParse(inputText, out int conversion))
                {
                    double inches = conversion * 39.3701;
                    rtbOutput.Text += ($"{conversion} meters is {inches} inches");

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputText = txtInput1.Text;
            string inputText1 = txtInput2.Text;
            if (chkKiloToMiles.Checked)
            {
                
                if (int.TryParse(inputText, out int conversion))
                {
                    double miles = conversion * 0.621371;
                    rtbOutput.Text += ($"{conversion} kilometers is {miles} miles");

                }
                if (int.TryParse(inputText1, out int conversion1))
                {
                    double miles = conversion1 * 0.621371;
                    rtbOutput.Text += ($"{conversion1} kilometers is {miles} miles");

                }
            }
            else if (chkInchToMeter.Checked)
            {
                if (int.TryParse(inputText, out int conversion))
                {
                    double meters = conversion * 0.0254;
                    rtbOutput.Text += ($"{conversion} inches is {meters} meters");

                }
                if (int.TryParse(inputText1, out int conversion1))
                {
                    double meters = conversion1 * 0.0254;
                    rtbOutput.Text += ($"{conversion1} inches is {meters} meters");

                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
        }

        private void FileLdBtn_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\jotha\OneDrive\Documents\GitHub\weekofnov6th-JothamSM\WeekOfNov6th\test.txt";


            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    rtbOutput.AppendText(line + Environment.NewLine); // Append each line to the RichTextBox
                }
            }
        }

        private void WorkitThrough_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtInput1.Text); // Get the value of n from the input1 TextBox

            if (n <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for 'n'.");
                return;
            }

            string filePath = @"C:\Users\jotha\OneDrive\Documents\GitHub\weekofnov6th-JothamSM\WeekOfNov6th\test.txt"; // Replace with the actual path to your text file

            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                string[] words = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = n - 1; i < words.Length; i += n)
                {
                    rtbOutput.AppendText(words[i] + " ");
                }
            }
        }

        private void AlphaArray_Click(object sender, EventArgs e)
        {
            char[] letters = new char[26];

            for (int i = 0; i < 26; i++)
            {
                letters[i] = (char)(65 + i); // ASCII code for 'A' is 65
            }
            for (int i = 0; i < letters.Length; i++)
            {
                char letter = letters[i];

                if ("AEIOU".Contains(letter)) // Check if the letter is a vowel
                {
                    rtbOutput.Text += (char.ToUpper(letter) + " "); // Uppercase vowel
                }
                else
                {
                    rtbOutput.Text += (char.ToLower(letter) + " "); // Lowercase non-vowel
                }
            }

            int j = letters.Length - 1;
            int count = 0;

            while (j >= 0)
            {
                char letter = letters[j];

                if (count % 5 == 0)
                {
                    if (char.IsUpper(letter))
                    {
                        rtbOutput.Text += (char.ToLower(letter) + ", ");
                    }
                    else
                    {
                        rtbOutput.Text += (char.ToUpper(letter) + ", ");
                    }
                }
                else
                {
                    rtbOutput.Text += (letter + " ");
                }

                j--;
                count++;
            }


        }
    }
}
