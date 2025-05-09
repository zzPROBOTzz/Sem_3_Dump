using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Meet Hingu
//30-10-2024
//section 1

namespace MainProjectSection1
{
    public partial class frmDashboard24 : Form
    {
        public frmDashboard24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lottoMax obj = new lottoMax();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lotto645 obj = new lotto645();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
