using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name Meet Hingu
// date 06/12/2024
//desc : the form for calculator
namespace meet_project
{
    public partial class calculatorForm : Form
    {
        private Calculator calculator = new Calculator();

        public calculatorForm()
        {
            InitializeComponent();
        }



        public class Calculator
        {
            public decimal operand1;
            public decimal operand2;
            public string operation;
            public decimal CurrentValue { get; private set; }

            public void SetOperand1(decimal value)
            {
                operand1 = value;
            }

            public void SetOperand2(decimal value)
            {
                operand2 = value;
            }

            public void SetOperation(string op)
            {
                operation = op;
            }

            public void Calculate()
            {
                switch (operation)
                {
                    case "+":
                        CurrentValue = operand1 + operand2;
                        break;
                    case "-":
                        CurrentValue = operand1 - operand2;
                        break;
                    case "*":
                        CurrentValue = operand1 * operand2;
                        break;
                    case "/":
                        CurrentValue = operand2 != 0 ? operand1 / operand2 : 0;
                        break;
                }
            }

        }


       

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            textBox1.Text = "";
        }

        private void calculator_Load(object sender, EventArgs e)
        {

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

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // = button
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(textBox1.Text, out decimal operand2))
                {
                    calculator.SetOperand2(operand2);
                    calculator.Calculate();

                    // Create the equation string
                    string equation = $"{calculator.operand1} {calculator.operation} {calculator.operand2}";
                    string equation2 = $"{calculator.operand1} {calculator.operation} {calculator.operand2} = {calculator.CurrentValue}";

                    // Display results
                    textBox1.Text = equation; // Full equation
                    textBox2.Text = equation2; // Result only
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
            }
        }
        // button 0 to 9

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        // operator buttons

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
           
            if (btn != null && decimal.TryParse(textBox1.Text, out decimal value))
            {
                calculator.SetOperand1(value);
                calculator.SetOperation(btn.Text); 
                textBox1.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (btn != null && decimal.TryParse(textBox1.Text, out decimal value))
            {
                calculator.SetOperand1(value);
                calculator.SetOperation(btn.Text);
                textBox1.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
           
            if (btn != null && decimal.TryParse(textBox1.Text, out decimal value))
            {
                calculator.SetOperand1(value);
                calculator.SetOperation(btn.Text);
                textBox1.Clear();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
          
            if (btn != null && decimal.TryParse(textBox1.Text, out decimal value))
            {
                calculator.SetOperand1(value);
                calculator.SetOperation(btn.Text);
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
