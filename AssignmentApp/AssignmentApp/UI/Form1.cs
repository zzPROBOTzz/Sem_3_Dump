using AssignmentApp.BLL;
using AssignmentApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentApp
{
    public partial class Form1: Form
    {
        private AssignmentService service = new AssignmentService();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = service.GetAllAssignments();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string title = textBox2.Text;
            string description = textBox3.Text;
            DateTime dueDate = dateTimePicker1.Value;

            service.AddAssignment(id, title, description, dueDate);
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);

            service.DeleteAssignment(id);
            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string title = textBox2.Text;
            string description = textBox3.Text;
            DateTime dueDate = dateTimePicker1.Value;

            service.updateAssignment(id, title, description, dueDate);
            LoadData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Assignment> assignments = new List<Assignment>();

            assignments = service.GetAssignmentByTitle(textBox4.Text);

            foreach (Assignment assignment in assignments)
            { 
                if(assignment.Title == textBox4.Text)
                {
                    label7.Text = assignment.Id + " " + assignment.Title + " " + assignment.Description + " " + assignment.DueDate;
                }
               
            }
           
        }
    }
}
