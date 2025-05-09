using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace midterm_section2
{
    public class AreaConvert
    {
        // Private fields
        private double sqCm;
        private double sqM;
        private double hectar;
        private double sqKm;

        // Constructor
        public AreaConvert(double sqCm, double sqM, double hectar, double sqKm)
        {
            this.sqCm = sqCm;
            this.sqM = sqM;
            this.hectar = hectar;
            this.sqKm = sqKm;
        }

        // Conversion methods
        public double ConvertSqCmToSqIn()
        {
            return sqCm * 0.155;
        }

        public double ConvertSqMToSqYd()
        {
            return sqM * 1.19599;
        }

        public double ConvertHectarToAcre()
        {
            return hectar * 2.47105;
        }

        public double ConvertSqKmToSqMile()
        {
            return sqKm * 0.386102;
        }
    }
    public partial class Form1 : Form
    {
        private AreaConvert converter;
        public Form1()
        {
            InitializeComponent();
        }

        private void frmAreaConvert_Load(object sender, EventArgs e)
        {
            // Set textboxes to default values
            txt1.Text = "0";
            txt2.Text = "0";
            txt3.Text = "0";
            txt4.Text = "0";
            txt5.Text = "0";
            txt6.Text = "0";
            txt7.Text = "0";
            txt8.Text = "0";

            // Display current date and time
            this.Text = "Area Converter - " + DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double sqCm = double.Parse(txt1.Text);
            converter = new AreaConvert(sqCm, 0, 0, 0);
            txt2.Text = converter.ConvertSqCmToSqIn().ToString();
            txt2.ReadOnly = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double sqM = double.Parse(txt3.Text);
            converter = new AreaConvert(0, sqM, 0, 0);
            txt4.Text = converter.ConvertSqMToSqYd().ToString();
            txt4.ReadOnly = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double hectar = double.Parse(txt5.Text);
            converter = new AreaConvert(0, 0, hectar, 0);
            txt6.Text = converter.ConvertHectarToAcre().ToString();
            txt6.ReadOnly = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            double sqKm = double.Parse(txt7.Text);
            converter = new AreaConvert(0, 0, 0, sqKm);
            txt8.Text = converter.ConvertSqKmToSqMile().ToString();
            txt8.ReadOnly = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit",
                                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
