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
//files and directories.

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

        string dir = @"C:\Files\";

        private void button5_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
                MessageBox.Show("Folder " + dir + "created");
            }
            else
            {
                MessageBox.Show("Folder " + dir + "existed.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(dir) == true)
            {
                Directory.Delete(dir, true);
                MessageBox.Show("Folder " + dir + "deleted.");
            }
            else
            {
                MessageBox.Show("Error 404.");
            }
        }

        string path = @"C:\Files\Dir";
        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists(path) == true)
            {
                File.Delete(path);
                MessageBox.Show("Folder " + path + "deleted.");
            }
            else
            {
                MessageBox.Show("Error 404.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string path = @"C:\Files\Dir";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs); 
            if (File.Exists(path) == true)
            {  // write the fields into text file
               textOut.Write("hello" + "|"); 
                textOut.WriteLine("hello world"); 
            } 
        }
    }
}
