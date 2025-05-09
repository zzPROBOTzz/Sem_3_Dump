using EmployeeManagement.BLL;
using EmployeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        private DepartmentService departmentService = new DepartmentService();
        private EmployeeService employeeService = new EmployeeService();
        private ProjectService projectService = new ProjectService();
        public Form1()
        {
            InitializeComponent();
            LoadDepartment();
            LoadEmployees();
            LoadProjects();
            LoadDepartmentsIntoComboBox();
            LoadEmployeeIntoComboBox();
        }

        //department add
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                departmentService.addDepartment(Convert.ToInt32(textBox1.Text),txtDepartmentName.Text);
                MessageBox.Show("Department added successfully");
                LoadDepartment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadDepartment()
        {
            DataTable dt = departmentService.getAllDepartments();
            dataGridView1.DataSource = dt;
        }

        private void LoadDepartmentsIntoComboBox()
        {
            DataTable dt = departmentService.getAllDepartments();

            comboBox1.DataSource = dt;

            comboBox1.DisplayMember = "DepartmentId";

            comboBox1.ValueMember = "DepartmentId";
        }

        private void LoadEmployeeIntoComboBox()
        {
            DataTable dt = employeeService.getAllEmployees();

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "EmployeeId";

            comboBox2.ValueMember = "EmployeeId";
        }

        private void LoadEmployees()
        {
            DataTable dt = employeeService.getAllEmployees();
            dataGridView3.DataSource = dt;
        }

        //department delete
        private void button2_Click(object sender, EventArgs e)
        {
            departmentService.deleteDepartment(Convert.ToInt32(textBox1.Text));
            MessageBox.Show("Department deleted successfully");
            LoadDepartment();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                employeeService.addEmployee(Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text);
                MessageBox.Show("Employee Added Successfully");
                LoadEmployees();
           
        }

        //load Projects
        public void LoadProjects()
        {
            DataTable dt = projectService.getAllProjects();
            dataGridView2.DataSource = dt;
        }


        //Exit
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            projectService.addProject(Convert.ToInt32(textBox8.Text), textBox8.Text);
            MessageBox.Show("Project Added Successfully");
            LoadProjects();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            employeeService.deleteEmployee(Convert.ToInt32(textBox3.Text));
            MessageBox.Show("Employee deleted successfully");
            LoadEmployees();
        }
    }
}
