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

namespace midtermWindowsForms
{
    public partial class frmLengthConvertor : Form
    {

        public class LengthConvert
        {
            //private fields
            private double meters;
            private double kilometers;

            //cunstrustor for meter
            public LengthConvert(double meters)
            {
                Meters = meters;
            }

            //construstor for km
            public LengthConvert(double kilometers, bool isKilometers)
            {
                Kilometers = kilometers;

            }
            //property for kilometer
            public double Kilometers
            {
                get { return kilometers; }
                set { kilometers = value; }
            }

            //property for meter
            public double Meters
            {
                get { return meters; }
                set { meters = value; }
            }

            //method to convert meter to centimeter
            public double mtocm()
            {
                return Meters * 100;
            }
            //method to convert kilometer to meter
            public double kmtom()
            {
                return Kilometers * 1000;
            }
            //method to conert meter to yards
            public double mtoyd()
            {
                return Meters * 1.0936;
            }
            //method to convert kilometer to miles
            public double kmtoml()
            {
                return Kilometers * 0.6214;
            }
            public void DisplayResults(double mValue)
            {
                Console.WriteLine($"For {mValue} m : {mtocm()} cm and {mtoyd()}yd");
            }
            public void DisplayResultsKm(double kmValue)
            {
                Console.WriteLine($"For {kmValue} km : {kmtom()} meter and {kmtoml()}miles");
            }
        }
        public frmLengthConvertor()
        {
            InitializeComponent();
        }
        private LengthConvert length;
        private void button2_Click(object sender, EventArgs e)
        {
            double meter = double.Parse(txtBox3.Text);
            length = new LengthConvert(meter);
            txtBox3.Text = length.mtoyd().ToString();
            txtBox3.ReadOnly = true;
        }

            private void btnReset_Click(object sender, EventArgs e)
        {
            txtbox1.Text = "0";
            txtBox2.Text = "0";
            txtBox3.Text = "0";
            txtBox4.Text = "0";
            txtBox5.Text = "0";
            txtBox6.Text = "0"; 
        }


        private void txtbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to leave?", "Exit confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
           
        }

        private void btnM_Yd_Click(object sender, EventArgs e)
        {
            double meter = double.Parse(txtBox2.Text);
            length = new LengthConvert(meter);
            txtBox2.Text = length.mtocm().ToString();
            txtBox2.ReadOnly = true;
        }
    }
}
