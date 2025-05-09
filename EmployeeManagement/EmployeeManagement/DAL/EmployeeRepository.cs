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
    public class EmployeeRepository
    {
        private readonly string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True;";

        public void addEmployee(employee employee)
        {
          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Employees(EmployeeId, Name, Email, DepartmentId) VALUES(@EmployeeId, @Name, @Email, @DepartmentId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", employee.employeeID);
                command.Parameters.AddWithValue("@Name", employee.name);
                command.Parameters.AddWithValue("@Email", employee.email);
                command.Parameters.AddWithValue("@DepartmentId", employee.departmentID);
                
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void deleteEmployee(int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable getAllEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }

        }
    }
}
