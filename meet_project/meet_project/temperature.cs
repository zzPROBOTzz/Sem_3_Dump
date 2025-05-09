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

// Name Meet Hingu
// date 06/12/2024
// desc : temperature form.

namespace meet_project
{
    public partial class temperature : Form
    {
        public temperature()
        {
            InitializeComponent();
        }

        double convertedTemp = 0;
        string conversionType = "";
        string message = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double inputTemp))
            {
                MessageBox.Show("Please enter a valid numeric temperature.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (radioButton1.Checked)
            {
                convertedTemp = (inputTemp * 9 / 5) + 32;
                conversionType = "Celsius to Fahrenheit";
                message = GetMessageForCelsius(inputTemp);

                label1.Text = "(°C)";  // Label for Celsius input
                label2.Text = "(°F)";  // Label for Fahrenheit output
            }

        
            else if (radioButton2.Checked)
            {
                convertedTemp = (inputTemp - 32) * 5 / 9;
                conversionType = "Fahrenheit to Celsius";
                message = GetMessageForFahrenheit(convertedTemp);

                label1.Text = "F";  // Label for Celsius input
                label2.Text = "C";  // Label for Fahrenheit output
            
        }
            else
            {
                MessageBox.Show("Please select a conversion type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Display results
            textBox2.Text = convertedTemp.ToString("F2");
            textBox3.Text = message;

            // Save the conversion to a text file
          //  SaveConversionToFile(inputTemp, convertedTemp, conversionType);
        }
        private string GetMessageForCelsius(double tempCelsius)
        {
            if (tempCelsius >= 100)
                return "Water Boils";
            else if (tempCelsius >= 40)
                return "Hot Bath";
            else if (tempCelsius >= 30)
                return "Beach Weather";
            else if (tempCelsius >= 21)
                return "Room Temperature";
            else if (tempCelsius >= 10)
                return "Cool Day";
            else if (tempCelsius >= 0)
                return "Freezing Point";
            else
                return "Extremely Cold";
        }

        private string GetMessageForFahrenheit(double tempFahrenheit)
        {
            if (tempFahrenheit >= 212)
                return "Water Boils";
            else if (tempFahrenheit >= 104)
                return "Hot Bath";
            else if (tempFahrenheit >= 86)
                return "Beach Weather";
            else if (tempFahrenheit >= 69.8)
                return "Room Temperature";
            else if (tempFahrenheit >= 50)
                return "Cool Day";
            else if (tempFahrenheit >= 32)
                return "Freezing Point";
            else
                return "Extremely Cold";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "./TempConversions.txt";
            string logEntry = $"{DateTime.Now}: {conversionType} - Input: {textBox1.Text}, Output: {textBox2.Text}";

            try
            {
                string directoryPath = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Append the log entry to the file
                File.AppendAllText(filePath, logEntry + Environment.NewLine);
                MessageBox.Show("Conversion saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Display the result in a message box
                string resultMessage = $"Conversion completed!\n{conversionType}:\nInput: {textBox1.Text}°\nOutput: {textBox2.Text}°\nMessage: {textBox3.Text}";
                MessageBox.Show(resultMessage, "Conversion Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving conversion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
