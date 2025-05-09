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
    public partial class lottoMax : Form
    {
        public lottoMax()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string randomNumbers = "";

            for (int i = 0; i < 8; i++)
            {
                int randomNumber = random.Next(1, 50);
                randomNumbers += randomNumber.ToString() + Environment.NewLine;
            }

            textBox1.Text = randomNumbers.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
