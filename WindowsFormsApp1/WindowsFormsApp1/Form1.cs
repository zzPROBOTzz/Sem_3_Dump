using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// name Meet hingu  date 9/10/2024 des calculator.
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Calc c1; 
        public Form1()
        {
            InitializeComponent();
            c1 = new Calc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.Num1 = Convert.ToDouble(txtNum1.Text);
            c1.Num2 = Convert.ToDouble(txtNum2.Text);
            textBox3.Text = c1.Add().ToString();
            //try
            //{
            //    double num1 = Convert.ToDouble(txtNum1.Text);
            //    double num2 = Convert.ToDouble(txtNum2.Text);
            //    textBox3.Text = (num1 + num2).ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Please enter valid numbers!", "Input Error");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                textBox4.Text = (num1 - num2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers!", "Input Error");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                textBox5.Text = (num1 * num2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers!", "Input Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                if (num2 != 0)
                {
                    textBox6.Text = (num1 / num2).ToString();
                }
                else
                {
                    MessageBox.Show("Cannot divide by zero!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers!", "Input Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cboOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboOperations.SelectedIndex == 0)
            {
                button1_Click(sender, e);
            }
            if(cboOperations.SelectedIndex == 1) { button2_Click(sender, e);}
            if(cboOperations.SelectedIndex == 2) { button3_Click(sender, e);}
            if (cboOperations.SelectedIndex == 3) {  button4_Click(sender, e);}
        }
    }
}
    

