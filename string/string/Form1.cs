using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Parteek Jain Date: 03/11/2024

namespace @string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string fullName = txtName.Text.Trim();

                // Split the name by spaces
                string[] nameParts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Check if there are enough parts for first, last, and optional middle name
                if (nameParts.Length < 2)
                {
                    MessageBox.Show("Please enter at least a first and last name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Format each part to capitalize the first letter and make remaining letters lowercase
                for (int i = 0; i < nameParts.Length; i++)
                {
                    nameParts[i] = char.ToUpper(nameParts[i][0]) + nameParts[i].Substring(1).ToLower();
                }

                // Prepare the output message based on number of parts
                string message;
                if (nameParts.Length == 2)
                {
                    // First and last name
                    message = $"First Name: {nameParts[0]}\nLast Name: {nameParts[1]}";
                }
                else
                {
                    // First, middle, and last name
                    message = $"First Name: {nameParts[0]}\nMiddle Name: {nameParts[1]}\nLast Name: {nameParts[2]}";
                }

                // Display the result in a message box
                MessageBox.Show(message, "Parsed Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the phone number input from the TextBox
            string phoneNumber = txtPhoneNumber.Text;

            // Remove all non-digit characters
            string digitsOnly = new string(phoneNumber.Where(char.IsDigit).ToArray());

            // Check if the result has exactly 10 digits
            if (digitsOnly.Length != 10)
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Format the phone number as XXX-XXX-XXXX
            string formattedPhoneNumber = $"{digitsOnly.Substring(0, 3)}-{digitsOnly.Substring(3, 3)}-{digitsOnly.Substring(6)}";

            // Display the formatted phone number in a message box
            MessageBox.Show($"Formatted Phone Number: {formattedPhoneNumber}", "Phone Number Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }
    }
}
