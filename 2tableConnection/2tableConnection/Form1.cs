using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2tableConnection
{
    public partial class Form1 : Form
    {

        private string ConnectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=Company;Trusted_Connection=True;";

        private DataSet dataSet;

        private SqlDataAdapter empAdapter;
        private SqlDataAdapter deptAdapter;

        private SqlCommandBuilder empBuilder;   
        private SqlCommandBuilder deptBuilder;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataSet = new DataSet();

            SqlConnection conn = new SqlConnection(ConnectionString);

            string empQuery = "SELECT * FROM Employee";

            empAdapter = new SqlDataAdapter(empQuery, conn);
            empBuilder = new SqlCommandBuilder(empAdapter);

            empAdapter.Fill(dataSet, "Employee");

            //Load department

            string deptQuery = "SELECT * FROM Department";

            deptAdapter = new SqlDataAdapter(deptQuery, conn);
            deptBuilder = new SqlCommandBuilder(deptAdapter);

            deptAdapter.Fill(dataSet, "Department");

            dataSet.Relations.Add("Dept_Emp", 
                dataSet.Tables["Department"].Columns["Department_id"], 
                dataSet.Tables["Employee"].Columns["Department_id"]);

            //delete one data from gridview

            string deleteEmployeeQuery = "DELETE FROM Employee WHERE Employee_id = @Employee_id";
            empAdapter.DeleteCommand = new SqlCommand(deleteEmployeeQuery, conn);
            // parameter 
            empAdapter.DeleteCommand.Parameters.Add("@Employee_id", SqlDbType.Int, 4, "Employee_id");



            //Binding data to gridview

            dataGridView1.DataSource = dataSet.Tables["Department"];
            dataGridView2.DataSource = dataSet.Tables["Employee"];
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //Exit
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Add employee
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Enter Name and Department Id");
                return;
            }

            DataRow row = dataSet.Tables["Employee"].NewRow();
            row["Employee_name"] = textBox4.Text;
            row["Employee_id"] = textBox3.Text;
            row["Department_id"] = textBox5.Text;
            dataSet.Tables["Employee"].Rows.Add(row);
        }

        //Add department
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Enter Department Name and ID");
                return;
            }
            DataRow row = dataSet.Tables["Department"].NewRow();
            row["Department_name"] = textBox2.Text;
            row["Department_id"] = textBox1.Text;
            dataSet.Tables["Department"].Rows.Add(row);
        }

        //for save or update    
        private void button2_Click_1(object sender, EventArgs e)
        {
            empAdapter.Update(dataSet, "Employee");

            deptAdapter.Update(dataSet, "Department");

            MessageBox.Show("Data Updated");
        }

        //for delete emp
        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    int employeeID = Convert.ToInt32(row.Cells["Employee_id"].Value);

                    //MessageBox.Show(employeeID.ToString());
                    //Find the row in the dataset and delete it 

                    foreach (DataRow empRow in dataSet.Tables["Employee"].Select($"Employee_id = {employeeID}"))
                    {
                        empRow.Delete();
                    }

                }

                // Apply changes to the database
                empAdapter.Update(dataSet, "Employee");
                MessageBox.Show("Employee Deleted Succesfully");
            }
            else
            {
                MessageBox.Show("Please Select an employee to delete.");
            }

        }
        //for delete dept

    }
}
