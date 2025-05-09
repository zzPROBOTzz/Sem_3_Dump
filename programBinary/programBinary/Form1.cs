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

namespace programBinary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string dirPath = @".\Files\"; 
        string path = dirPath + "ProductsB.txt"; 
        FileStream fs = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(dirPath) == false) Directory.CreateDirectory(dirPath);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim().Length > 0 &&
                    textBox2.Text.Trim().Length > 0 &&
                    Convert.ToByte(textBox3.Text.Trim()) > 0)
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write); // code that uses the file stream  // to read and write data from the file
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(textBox1.Text.Trim());
                    bw.Write(textBox2.Text.Trim());
                    bw.Write(Convert.ToByte(textBox3.Text.Trim()));
                    bw.Close();
                }
                else
                {
                    MessageBox.Show("Enter all the data");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "0";
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dirPath + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                // code that uses the file stream  // to read and write data from the file
                BinaryReader br = new BinaryReader(fs);
                string textToPrint = "Fname \t Lname\t age\n";
                string Fname, Lname;
                byte age;

                while(br.PeekChar()!= -1)
                {
                    Fname = br.ReadString();
                    Lname = br.ReadString();
                    age = br.ReadByte();
                    textToPrint = Fname+"\t"+ Lname +"\t" +(age+1)+"\n";
                }
                br.Close();
                MessageBox.Show(textToPrint);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dirPath + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(File.Exists(path) == true)
            {
                File.Delete(path);
                MessageBox.Show("File deleted.");
            }
            else
            {
                MessageBox.Show("File is not exist.");
            }
        }
    }
}
