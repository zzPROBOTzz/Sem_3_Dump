using CodeFirstWF_Project.Business;
using System;
using CodeFirstWF_Project.Model;
using System.Windows.Forms;

namespace CodeFirstWF_Project.GUI
{
    public partial class LoginForm : Form
    {
        ProjectSchoolService schoolService = new ProjectSchoolService();
       

        public LoginForm()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            schoolService.userLogin(username, password);

            if (username == "admin" && password == "password")
            {
                FinalProject form1 = new FinalProject();
                this.Hide();
                form1.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Password and username");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
