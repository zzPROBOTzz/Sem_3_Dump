using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllProject;

namespace minicalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1 = 0;
        int num2 = 0;
        static string res = "";

        private void button1_Click(object sender, EventArgs e)
        {
            calculate calculate = new calculate();  
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (num1 + num2).ToString();
            res = num1.ToString() + "+" + num2.ToString() + "=" + (num1 + num2).ToString();
            textBox4.Text = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculate calculate = new calculate();
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (num1 - num2).ToString();
            res = num1.ToString() + "-" + num2.ToString() + "=" + (num1 - num2).ToString();
            textBox4.Text = res;
        }
    }
}
