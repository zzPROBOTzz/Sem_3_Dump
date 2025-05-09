using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create connectionString
            string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;";

            while (true)
            {
                Console.WriteLine("Student management system");
                Console.WriteLine("1. View All students");
                Console.WriteLine("2. Add a student");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        viewAllBooks(connectionString);
                        break;
                    case "2":
                        addNewBook();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. please try again ");
                        break;
                }
            }
        }

        static void viewAllBooks(string connectionString)
        {
            //Connected Mode 
            //1.(SqlConnection object (Create connect object with connectionString)
            //2. SqlCommand Object (create and prepare my Query)
            //3.SqlDataReader Object (execute and read my Data)



            // use my connection string and prepare the query to select all the books 
            // connection object 
            // using is a method we create object when we finish our job  then we delete the object
            // // it is security 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // all the time we use try and catch 
                try
                {
                    //first I should ask the database to open or open the connection 

                    connection.Open();
                    // create my command my query 
                    string query = "SELECT * FROM Students";
                    // ask sql to run my command 
                    // hey sql do my order do my command 
                    SqlCommand command = new SqlCommand(query, connection);

                    // Important 
                    // I am getting data from database and I should know how to read it 

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("StudentID/Name/Age/Grade");
                        // as long as I have data read the rows in database 
                        // I want to be sure , i do not miss any rows (any data)

                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["StudentID"]}\t {reader["Name"]}\t{reader["Age"]}\t{reader["Grade"]}");
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }



        }

        static void addNewBook()
        {
            Console.WriteLine("Enter student id:");
            int studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student's Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter student's age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student's Marks:");
            int grade = int.Parse(Console.ReadLine());
        }
    }
}