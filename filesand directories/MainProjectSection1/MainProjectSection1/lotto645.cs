using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProjectSection1
{
    public partial class lotto645 : Form
    {
        public lotto645()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string randomNumbers = "";

            for (int i = 0; i < 7; i++)
            {
                int randomNumber = random.Next(1, 49);
                randomNumbers += randomNumber.ToString() + Environment.NewLine;
            }

            textBox1.Text = randomNumbers.Trim();
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            this.Close();
        }
    }
}
