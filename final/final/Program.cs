using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Position;
        public double Salary;
    }

    internal class Program
    {
        static Employee[] employees = new Employee[10];
        static int currentIndex = 0;


        static void Main(string[] args)
        {
            while (true)
            {
                ShowMainManu();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ShowAllEmployees();
                        break;
                    case 3:
                        ModifyOneEmployeeById();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }


        }

        static void AddEmployee()
        {
            if (currentIndex < employees.Length)
            {
                Employee newEmployee = new Employee();
                Console.WriteLine($"\nEnter details for employee number {currentIndex + 1}");
                Console.Write("Enter ID: ");
                newEmployee.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the first name: ");
                newEmployee.FirstName = Console.ReadLine();
                Console.WriteLine("Enter the last name: ");
                newEmployee.LastName = Console.ReadLine();
                Console.WriteLine("Enter the Positon: ");
                newEmployee.Position = Console.ReadLine();
                Console.WriteLine("Enter the salary");
                newEmployee.Salary = double.Parse(Console.ReadLine());

                employees[currentIndex] = newEmployee;
                currentIndex++;
            }
            else
            {
                Console.WriteLine("Employee Database is full");
            }
        }
        static void ShowAllEmployees()
        {

            Console.WriteLine("\nEmployee details:");
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine($"\nEmployee {i + 1}");
                Console.WriteLine("First name :" + employees[i].FirstName);
                Console.WriteLine("Last name :" + employees[i].LastName);
                Console.WriteLine("Position :" + employees[i].Position);
                Console.WriteLine("Salary :" + employees[i].Salary);

            }
        }

        static void ModifyOneEmployeeById()
        {
            Console.Write("\nEnter the ID of the employee you want to modify: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < currentIndex; i++)
            {
                if (employees[i].Id == id)
                {
                    Console.WriteLine($"\nModify Employee {employees[i].Id} - {employees[i].FirstName} {employees[i].LastName}");
                    Console.Write("Enter New First Name: ");
                    employees[i].FirstName = Console.ReadLine();

                    Console.Write("Enter New Last Name: ");
                    employees[i].LastName = Console.ReadLine();

                    Console.Write("Enter New Position: ");
                    employees[i].Position = Console.ReadLine();

                    Console.Write("Enter New Salary: ");
                    employees[i].Salary = double.Parse(Console.ReadLine());
                    return;
                }
            }

            Console.WriteLine("\nEmployee with ID " + id + " not found.");
        }
        static void ShowMainManu()
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display Employees");
            Console.WriteLine("3. Modify Employee by ID");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
        }
    }
}