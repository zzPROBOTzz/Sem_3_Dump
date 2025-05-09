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
    public class DepartmentRepository
    {
        private readonly string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";

       public void addDepartment(department department)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Departments(DepartmentId,DepartmentName) VALUES(@DepartmentId,@DepartmentName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DepartmentId", department.DepartmentID1);
                command.Parameters.AddWithValue("@DepartmentName", department.DepartmentName1);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        
        public void deleteDepartment(int departmentID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Departments WHERE DepartmentID = @DepartmentID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DepartmentID", departmentID);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public DataTable getAllDepartments()
        {
           using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Departments";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        
        }

        
    }
}
