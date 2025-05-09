using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using technoCollegeManagement.BAL;

namespace technoCollegeManagement
{
    public partial class Form1 : Form
    {
        public RegistrationService registrationService;

        public Form1()
        {
           
            InitializeComponent();
            registrationService = new RegistrationService();
            LoadApplicants();
            LoadWebinars();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        
        
        // Add Applicant
        private void button1_Click(object sender, EventArgs e)
        {
            int appId = Convert.ToInt32(textBox1.Text);
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string email = textBox4.Text;

            registrationService.AddApplicant(appId, firstName, lastName, email);
        }

        public void LoadApplicants()
        {
            DataTable applicants = registrationService.applicantRepository.GetAllApplicants();

            // Check if the applicants DataTable is null or empty
            if (applicants == null || applicants.Rows.Count == 0)
            {
                MessageBox.Show("Your Applicants table is empty.");
                return;
            }

            // Create a FullName column by combining first and last name if it doesn't exist
            if (!applicants.Columns.Contains("FullName"))
            {
                applicants.Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");
            }

            comboBox2.DataSource = applicants;
            comboBox2.DisplayMember = "FullName";
            comboBox2.ValueMember = "AppId";


            dataGridView1.DataSource = applicants;

           // dataGridView1.DataSource = registrationService.applicantRepository.GetAllApplicants();
        }



        private void LoadWebinars()
        {
            DataTable webinars = registrationService.webinarRepository.GetAllWebinars();
            comboBox1.DisplayMember = "WebinarName";
            comboBox1.ValueMember = "WebinarCode";
            comboBox1.DataSource = webinars;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registrationService.DeleteApplicant(Convert.ToInt32(textBox1.Text));
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
        }
    }
}
