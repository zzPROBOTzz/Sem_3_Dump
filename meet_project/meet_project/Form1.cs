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
// desc : main form.

namespace meet_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lotto649 obj = new lotto649();
            obj.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lottoMax obj = new lottoMax();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ipv4 obj = new ipv4();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moneyConvertor obj = new moneyConvertor();
            obj.Show(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculatorForm obj = new calculatorForm();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            temperature obj = new temperature();
            obj.Show();
        }
    }
}
