using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumberGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal numberGrade = Convert.ToDecimal(cboValues.SelectedItem);

            string letterGrade = "";

            if (numberGrade >= 88) { 
                letterGrade = "A"; 
                } 
            else if (numberGrade >= 80 && numberGrade <= 87) { 
                letterGrade = "B"; 
                } 
            else if (numberGrade >= 68 && numberGrade <= 79) { 
                letterGrade = "C"; 
                } 
            else if (numberGrade >= 60 && numberGrade <= 67) { 
                letterGrade = "D"; 
                } 
            else { 
                letterGrade = "F"; 
                }

            txtLetterGrade.Text = letterGrade;
            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboValues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++) { 
                cboValues.Items.Add(i);
            }
          
        }
    }
}
