using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Final_exam_oop
{
    //Name Meet Hingu
    //date 18/12/2024
    // desc: Final Exam
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class Validator
        {
            public static bool ValidateYear(string year)
            {
                return Regex.IsMatch(year, @"^(2024|2025|2026|2027|2028)$");
            }

            public static bool ValidateSession(string session)
            {
                return Regex.IsMatch(session, @"^(Fall|Winter|Summer)$", RegexOptions.IgnoreCase);
            }


        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

       
        private void fbt_button2_Click(object sender, EventArgs e)
        {
            string year = ftx_txtBox3.Text.Trim();
            string session = ftx_txtBox2.Text.Trim();


            if (!Validator.ValidateYear(year))
            {
                MessageBox.Show("Invalid Year. Please enter a value between 2024 and 2028.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Session
            if (!Validator.ValidateSession(session))
            {
                MessageBox.Show("Invalid Session. Please enter Fall, Winter, or Summer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form2 obj = new Form2();
            obj.Show();
        }

        private void fbt_button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void fbt_button1_Click(object sender, EventArgs e)
        {
            ftx_txtBox2.Text = "";
            ftx_txtBox3.Text = "";
        }
    }
}
