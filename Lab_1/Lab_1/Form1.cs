using BookStore.BLL;
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

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private readonly BookBLL bookBLL = new BookBLL();

        string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=BookstoreDB;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            loadAuthors();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = bookBLL.GetBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string author = textBox2.Text;
            string price = textBox3.Text;
            

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                string insertQuery = "INSERT INTO BOOKS (Title,AuthorID,Price) VALUES (@Title,@AuthorId,@Price)";

                SqlCommand command = new SqlCommand(insertQuery, conn);

                //command.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@AuthorID", author);
                command.Parameters.AddWithValue("@Price", price);


                // Execute 
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book added successfully! ");
                    loadBooks();
                }
                else
                {
                    MessageBox.Show("Failed to add Book ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }
        public void loadBooks()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Books";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        public void loadAuthors()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Authors";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                string selectQuery = "SELECT * FROM BOOKS";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);

                // reader object I should read the data 
                // ExecuteReader() because I want to retrive data 
                SqlDataReader reader = cmd.ExecuteReader();

                // How to use DataGridView 
                // I will create a fake table in c# , get data and put(Load) in the fake table then I will read data and assign this fake table 
                // to dataGridView 
                DataTable dt = new DataTable();
                dt.Load(reader);
                // assign this fake table to dataGridView 
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

