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
    public class ApplicantRepository
    {
        private readonly string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=technoColloegeManagement;Integrated Security=True;";
        private DataSet dataSet;
        private SqlDataAdapter applicantAdapter;
        private SqlCommandBuilder applicantBuilder;

        public ApplicantRepository()
        {
            dataSet = new DataSet();
            applicantAdapter = new SqlDataAdapter("SELECT * FROM applicants", connectionString);
            applicantBuilder = new SqlCommandBuilder(applicantAdapter);
        }

        public void AddApplicant(Applicant applicant)
        {
            DataTable table = new DataTable();
            applicantAdapter.Fill(table);

            // Add new Row for new Applicant 
            DataRow newRow = table.NewRow();
            newRow["AppId"] = applicant.AppId;
            newRow["FirstName"] = applicant.FirstName;
            newRow["LastName"] = applicant.LastName;
            newRow["Email"] = applicant.Email;

            table.Rows.Add(newRow);
            //applicantAdapter.Update(table);
        }

        public DataTable GetAllApplicants()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = $"SELECT * FROM applicants";
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

        public void DeleteApplicant(int appId)
        {
            DataTable table = new DataTable();
            applicantAdapter.Fill(table);

            DataRow row = table.Select($"AppId = {appId}").FirstOrDefault();
            if (row != null)
            {
                row.Delete();
                //applicantAdapter.Update(table);
            }
        }

        public void SaveChanges()
        {
            applicantAdapter.Update(dataSet);
        }
    }
}
