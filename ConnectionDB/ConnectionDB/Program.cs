using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create connection string
            string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;";

            while (true)
            {
                Console.WriteLine("Student Management System");
                Console.WriteLine("1. View All Students");
                Console.WriteLine("2. Add a New Student");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewAllStudents(connectionString);
                        break;
                    case "2":
                        AddNewStudent(connectionString);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ViewAllStudents(string connectionString)
        {
            // TODO: Implement logic to retrieve and display all students
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM StudentDB ";
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("StudentID/ Name/ Age/ Grade");
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["StudentID"]}\t {reader["Name"]} \t {reader["Age"]}{reader["Grade"]}");
                        }

                    }
                }
                catch (Exception ex)
                { Console.WriteLine($"Error : {ex.Message}"); }
            }
        
    }

        static void AddNewStudent(string connectionString)
        {
            // TODO: Implement logic to add a new student
        }
    }
}