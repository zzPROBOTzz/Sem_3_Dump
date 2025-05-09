using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DemoDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            while (true)
            {
                Console.WriteLine("Student management system");
                Console.WriteLine("1.View All Books");
                Console.WriteLine("2.Add a Book");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Choose an option: \n");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        viewAllBooks(connectionString);
                        break;
                    case "2":
                        addNewBook(connectionString);
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {

                    connection.Open();

                    string query = "SELECT * FROM Books";

                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Title/ Author/ PublishedYear\n");

                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["Title"]}\t {reader["Author"]}\t{reader["PublishedYear"]}");
                            Console.WriteLine("\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        static void addNewBook(string connectionString)
        {
            Console.WriteLine("Enter the book title: ");
            string Title = Console.ReadLine();

            Console.WriteLine("Enter the Author name: ");
            string Auther = Console.ReadLine();

            Console.WriteLine("Enter the published year: ");
            int PublishedYear = int.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO BOOKS(Title, Author, PublishedYear) VALUES(@Title, @Author, @PublishedYear)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Title", Title);
                        command.Parameters.AddWithValue("@Author", Auther);
                        command.Parameters.AddWithValue("@PublishedYear", PublishedYear);

                        int rowEffected = command.ExecuteNonQuery();

                        if (rowEffected > 0)
                        {
                            Console.WriteLine("Books added successfully");
                        }
                        else
                        {
                            Console.Write("Failed to added book.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");

                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");

                }
                }
        }
    }
}

