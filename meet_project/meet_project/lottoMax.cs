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

//name Meet Hingu
//date 06/12/2024
//desc 

namespace meet_project
{
    public partial class lottoMax : Form
    {
        public lottoMax()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            string randomNumbers = "";

            string lotteryName = "Max"; // Example lottery name
            for (int i = 0; i < 7; i++)
            {
                int randomNumber = random.Next(1, 49);
                randomNumbers += randomNumber.ToString() + Environment.NewLine;
            }
            int extraNumber = new Random().Next(1, 50); // Generate an extra number
            string timestamp = DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt");

            // Format the result
            string result = $"{lotteryName}, {timestamp}, {string.Join(",", randomNumbers)} Extra {extraNumber}";

            // Display in the TextBox
            textBox1.Text += randomNumbers + Environment.NewLine;

            // Save to file
            SaveToFile("LottoNbrs.txt", result);
        }



        private void SaveToFile(string filePath, string content)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(content);
            }
        }

        private void temperature_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a message box with Yes and No options
            var dialogResult = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Check the user's response
            if (dialogResult == DialogResult.No)
            {
                // If the user clicks "No", cancel the form closing
                e.Cancel = true;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                // If the user clicks "Yes", proceed with the form closing
                e.Cancel = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private string ReadFromFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                return reader.ReadToEnd();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileContent;
            using (FileStream fs = new FileStream("LottoNbrs.txt", FileMode.OpenOrCreate, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                fileContent = reader.ReadToEnd();
            }

            // If file is empty, show a message
            if (string.IsNullOrWhiteSpace(fileContent))
            {
                MessageBox.Show("No data available in the file.", "File Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Split content into lines
            string[] lines = fileContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Prepare the output message
            string message = "Lotto Numbers:\n";
            foreach (var line in lines)
            {
                message += line + "\n";
            }

            // Display the result in a message box
            MessageBox.Show(message, "File Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
        }
    }
}
