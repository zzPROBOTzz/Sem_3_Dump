using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL
{
    public class ProjectRepository
    {
        private readonly string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";

        public void addProject(project project)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Projects(ProjectId, ProjectName) VALUES(@ProjectId, @ProjectName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProjectId", project.ProjectID);
                command.Parameters.AddWithValue("@ProjectName", project.ProjectName);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable getAllProjects()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Projects";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }

}
