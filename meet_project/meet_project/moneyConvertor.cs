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
using static System.Resources.ResXFileRef;

// Name Meet Hingu
// date 06/12/2024
// desc : moneyConvertor form.

namespace meet_project
{
    public partial class moneyConvertor : Form
    {
        public moneyConvertor()
        {
            InitializeComponent();
        }

        public class MoneyConv
        {
            // Conversion factors relative to CAD
            private readonly double[] exchangeRates = { 1.00, 0.7353, 0.6757, 0.5952, 61.23, 0.000023 }; // INR and Bitcoin rates
            private readonly string[] currencyCodes = { "CAD", "USD", "EUR", "GBP", "INR", "BTC" };

            public bool IsValidAmount(string amount)
            {
                // Validate input format (0.00 to 999.99)
                string pattern = @"^\d{1,3}(\.\d{1,2})?$";
                return Regex.IsMatch(amount, pattern);
            }

            public double[] ConvertAmount(double baseAmount)
            {
                double[] results = new double[exchangeRates.Length];
                for (int i = 0; i < exchangeRates.Length; i++)
                {
                    results[i] = Math.Round(baseAmount * exchangeRates[i], 2);
                }
                return results;
            }

            public void SaveConversions(string baseCurrency, double baseAmount, double[] conversions)
            {
                string filePath = "MoneyConversions.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    string dateTime = DateTime.Now.ToString("yyyy/MM/dd (hh:mm:ss tt)");
                    string log = $"{dateTime}, {baseAmount} {baseCurrency} = ";

                    for (int i = 0; i < conversions.Length; i++)
                    {
                        log += $"{conversions[i]} {currencyCodes[i]}";
                        if (i < conversions.Length - 1) log += "; ";
                    }

                    writer.WriteLine(log);
                }
            }

            public string ReadConversions()
            {
                string filePath = "MoneyConversions.txt";
                if (!File.Exists(filePath))
                    return "No conversion records found.";

                using (StreamReader reader = new StreamReader(filePath))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoneyConv converter = new MoneyConv();
            string amountText = textBox1.Text.Trim();

            if (!converter.IsValidAmount(amountText))
            {
                MessageBox.Show("Invalid amount! Enter a value between 0.00 and 999.99.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double baseAmount = double.Parse(amountText);
            double[] conversions = converter.ConvertAmount(baseAmount);

            // Display results in respective TextBoxes
            textboxCAD.Text = conversions[0].ToString("F2");
            textboxUSA.Text = conversions[1].ToString("F2");
            textboxEUR.Text = conversions[2].ToString("F2");
            textboxGBP.Text = conversions[3].ToString("F2");
            textboxINR.Text = conversions[4].ToString("F2"); // INR
            textboxBTC.Text = conversions[5].ToString("F6");

           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string amountInput = textBox1.Text.Trim();

            // Check if the input is not empty
            if (string.IsNullOrEmpty(amountInput))
            {
                MessageBox.Show("Please enter a value before clicking the button.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MoneyConv converter = new MoneyConv();
                string amountText = textBox1.Text.Trim();


                double baseAmount = double.Parse(amountText);
                double[] conversions = converter.ConvertAmount(baseAmount);

                // Display results in respective TextBoxes
                textboxCAD.Text = conversions[0].ToString("F2");
                textboxUSA.Text = conversions[1].ToString("F2");
                textboxEUR.Text = conversions[2].ToString("F2");
                textboxGBP.Text = conversions[3].ToString("F2");
                textboxINR.Text = conversions[4].ToString("F2"); // INR
                textboxBTC.Text = conversions[5].ToString("F6");
                string message = $"Conversion results:\n" +
                     $"2024/12/06 ({DateTime.Now:hh:mm:ss tt}), {baseAmount} CAD = " +
                     $"{conversions[0]} CAD; {conversions[1]} USD; {conversions[2]} EUR; " +
                     $"{conversions[3]} GBP; {conversions[4]} INR; {conversions[5]} BTC";

                MessageBox.Show(message, "Conversion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            private void button3_Click(object sender, EventArgs e)
        {
            if (button3.clicked)
            {

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
    }
    

}
