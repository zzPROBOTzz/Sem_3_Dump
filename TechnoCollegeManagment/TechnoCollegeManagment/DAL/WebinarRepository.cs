using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnoCollegeManagment.Models;

namespace TechnoCollegeManagment.DAL
{
    public class WebinarRepository
    {
        private readonly string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=technoColloegeManagement;Integrated Security=True;";
        private DataSet dataSet;
        private SqlDataAdapter webinarAdapter;
        private SqlCommandBuilder webinarBuilder;

        public WebinarRepository()
        {
            dataSet = new DataSet();
            webinarAdapter = new SqlDataAdapter("SELECT * FROM Webinars", connectionString);
            webinarBuilder = new SqlCommandBuilder(webinarAdapter);
        }

        public void AddWebinar(Webinar webinar)
        {
            DataTable table = new DataTable();
            webinarAdapter.Fill(table);

            DataRow newRow = table.NewRow();
            // Assuming Webinar class has properties like WebinarId, Title, Date, etc.
            newRow["WebinarCode"] = webinar.WebinarCode1;
            newRow["WebinarName"] = webinar.WebinarName1;
            newRow["StartingDate"] = webinar.StartingDate1;
            newRow["TotalHours"] = webinar.TotalHours1;
            newRow["EndingDate"] = webinar.EndingDate1;

            table.Rows.Add(newRow);
            webinarAdapter.Update(table);
        }

        // List 
        public DataTable GetAllWebinars()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = $"SELECT * FROM webinars";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }
    

        public void DeleteWebinar(int webinarId)
        {
            DataTable table = new DataTable();
            webinarAdapter.Fill(table);

            DataRow row = table.Select($"WebinarId = {webinarId}").FirstOrDefault();
            if (row != null)
            {
                row.Delete();
                webinarAdapter.Update(table);
            }
        }

        public void SaveChanges()
        {
           webinarAdapter.Update(dataSet);
        }
    }
}
