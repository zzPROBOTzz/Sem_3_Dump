using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoCollegeManagment.BLL;

namespace TechnoCollegeManagment
{
    public partial class Form1 : Form
    {
        // create an object of RegistrationService 
        public RegistrationService registrationService;
        public Form1()
        {
            InitializeComponent();
            registrationService = new RegistrationService();
            LoadApplicants();
            LoadWebinars();
        }

        private void buttonAddApplicant_Click(object sender, EventArgs e)
        {
            int ApplicantId = Convert.ToInt32(textBoxApplicantID.Text);
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string email = textBoxEmail.Text;

           
            //registrationService.AddApplicant(ApplicantId,firstName,lastName,email);

            registrationService.AddApplicant(Convert.ToInt32(textBoxApplicantID.Text), textBoxFirstName.Text,
                                              textBoxLastName.Text, textBoxEmail.Text);


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Load applicants into ComboBox
        private void LoadApplicants()
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

            comboBoxApplicants.DataSource = applicants;
            comboBoxApplicants.DisplayMember = "FullName";
            comboBoxApplicants.ValueMember = "AppId";

           
            dataGridView1.DataSource = applicants;
        }

        // Load webinars into ComboBox
        private void LoadWebinars()
        {
            DataTable webinars = registrationService.webinarRepository.GetAllWebinars();
            comboBoxWebinars.DisplayMember = "WebinarName";
            comboBoxWebinars.ValueMember = "WebinarCode";
            comboBoxWebinars.DataSource = webinars;
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {

            // I want to add data it is good to use try & Catch 

            try
            {
                // add Some validation 
                // Check if an applicant is selected 
                if(comboBoxApplicants.SelectedValue == null)
                {
                    MessageBox.Show("Please select an applicant.", "Warning");
                    return;
                }

                // Check if a webinar is selected 
                if(comboBoxWebinars.SelectedValue == null)
                {
                    MessageBox.Show("Please select a webinar.", "Warning");
                    return;
                }

                // convert ApplicantId to int 
                int selectedApllicantId = Convert.ToInt32(comboBoxApplicants.SelectedValue);
                string selectedWebinarId = comboBoxWebinars.SelectedValue.ToString(); 
                
                registrationService.RegisterApplicantToWebinar(selectedApllicantId, selectedWebinarId);
                MessageBox.Show("Applicant registered for the webinar successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registration Failed");
            }

            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            registrationService.updateDataBase();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string WebinarCode = textBox1.Text;
            string WebinarName = textBox2.Text;
            int TotalHours = Convert.ToInt32(textBox3.Text);
            //DateTime EndingDate = dateTimePickerEndingDate.Value;

            registrationService.AddWebinar(WebinarCode, WebinarName, DateTime.Now, Convert.ToInt32(textBox3.Text), DateTime.Now);
        }

        public void loadWebinarData()
        {
            DataTable webinars = registrationService.webinarRepository.GetAllWebinars();
            dataGridView1.DataSource = webinars;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registrationService.DeleteWebinar(Convert.ToInt32(label1.Text));
        }

        private void buttonDeleteApplicant_Click(object sender, EventArgs e)
        {
            registrationService.DeleteApplicant(Convert.ToInt32(textBoxApplicantID.Text));
        }
    }
}
