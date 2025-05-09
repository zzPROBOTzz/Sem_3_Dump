using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parteee
{
    public partial class Parteek : Form
    {
        public Parteek()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();
            obj.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
