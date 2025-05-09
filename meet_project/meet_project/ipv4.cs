using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// Name Meet Hingu
// date 06/12/2024
// desc : ipv4 and ipv6 form.

namespace meet_project
{
   

    public partial class ipv4 : Form
    {
        public ipv4()
        {
            InitializeComponent();
        }
        public class IPv4IPv6Conv
        {
            // Validate IPv4
            public bool IsValidIPv4(string ip)
            {
                string pattern = @"^(\d{1,3}\.){3}\d{1,3}$";
                if (Regex.IsMatch(ip, pattern))
                {
                    string[] parts = ip.Split('.');
                    foreach (string part in parts)
                    {
                        if (int.Parse(part) > 255) return false;
                    }
                    return true;
                }
                return false;
            }

            // Validate IPv6
            public bool IsValidIPv6(string ip)
            {
                string pattern = @"^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$";
                return Regex.IsMatch(ip, pattern);
            }
            public void SaveIP(string type, string ip)
            {
                string filePath = "IPRecords.txt";
                using (FileStream fs = new FileStream(filePath, FileMode.Append))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write($"{type}: {ip}");
                    writer.Write(DateTime.Now.ToString());
                }
            }
        }


        private void ipv4_Load(object sender, EventArgs e)
        {
            label3.Text = "Today :" + DateTime.Now.ToLongDateString();
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
        private void button4_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            MessageBox.Show("Data has been Reset.");
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ipv4 = textBox1.Text.Trim(); // IPv4 input
            string ipv6 = textBox2.Text.Trim(); // IPv6 input

            try
            {
                IPv4IPv6Conv converter = new IPv4IPv6Conv();

                if (converter.IsValidIPv4(ipv4))
                {
                    converter.SaveIP("IPv4", ipv4);
                    MessageBox.Show($"{ipv4} \n This ip is correct !");
                }
                else if (converter.IsValidIPv6(ipv6))
                {
                    converter.SaveIP("IPv6", ipv6);
                    MessageBox.Show($"{ipv6} \n This IP is Correct !");
                }
                else if(!converter.IsValidIPv4(ipv4))
                {
                    MessageBox.Show($"{ipv4} \n this ip must have 4 bytes integer number between 0 to 255 separated by a dot(255.255.255.255)");
                }
                else if (!converter.IsValidIPv4(ipv6))
                {
                    MessageBox.Show($"{ipv6} \n this ip must have 16 bytes integer number and text between 0 to 255 and a to f consecutevaly separated by a colan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ipv4 = textBox1.Text.Trim();
            string ipv6 = textBox2.Text.Trim();

            // Check if both fields are empty
            if (string.IsNullOrEmpty(ipv4) && string.IsNullOrEmpty(ipv6))
            {
                MessageBox.Show("Both fields are empty. Please enter an IP address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Display the entered IP addresses in a message box
                string message = "Entered IP Addresses:\n";
                if (!string.IsNullOrEmpty(ipv4))
                {
                    message += $"IPv4: {ipv4}\n";
                }
                if (!string.IsNullOrEmpty(ipv6))
                {
                    message += $"IPv6: {ipv6}\n";
                }

                MessageBox.Show(message, "Entered IP Addresses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
