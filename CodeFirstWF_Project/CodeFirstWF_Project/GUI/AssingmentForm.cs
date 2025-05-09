using CodeFirstWF_Project.Business;
using CodeFirstWF_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstWF_Project
{
    public partial class FinalProject: Form
    {
        ProjectSchoolService schoolService = new ProjectSchoolService();

        public FinalProject()
        {
            InitializeComponent();
            loadCourse();
            loadTeacher();
            loadCourseAssign();
        }

        public void loadCourse()
        {
            dataGridView1.DataSource = schoolService.showCourses();
        }

        public void loadTeacher()
        {
            dataGridView2.DataSource = schoolService.showTeachers();
        }

        public void loadCourseAssign()
        {
            dataGridView3.DataSource = schoolService.showAssignCourse();

            var course = schoolService.showCourses();
            comboBox1.DataSource = course;
            comboBox1.DisplayMember = "courseName";
            comboBox1.ValueMember = "courseId";
            
            var teacher = schoolService.showTeachers();
            comboBox2.DataSource = teacher;
            comboBox2.DisplayMember = "firstName";
            comboBox2.ValueMember = "teacherId";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            String name = textBox2.Text;
            
            schoolService.addCourse(id, name);
            loadCourse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox3.Text);
            String firstName = textBox4.Text;
            String lastName = textBox5.Text;

            schoolService.addTeacher(id, firstName, lastName);
            loadTeacher();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int assignId = Convert.ToInt32(textBox6.Text);
            int courseId = Convert.ToInt32(comboBox1.SelectedValue);
            int teacherId = Convert.ToInt32(comboBox2.SelectedValue);

            schoolService.assignCourses(assignId, courseId, teacherId);
            loadCourseAssign();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
