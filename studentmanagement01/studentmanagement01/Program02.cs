using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Name : Meet hingu date: 15/09/2024 about: student management upadated with struct

namespace studentmanagement02
{
    struct student
    {
        public string Name;
        public int Age;
        public int Id;
        public string CollegeName;
        public string City;
        public string Address;
    }
    class program
    {
        static student[] students = new student[5];
        static int studentCount = 0;


        static void Main(string[] args)
        {
            bool running = true;
            do
            {
                Console.WriteLine("Student management system");
                Console.WriteLine("1. Enter new student information");
                Console.WriteLine("2. Display student information");
                Console.WriteLine("3. Quit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        if (studentCount < students.Length)
                        {
                            EnterStudentInformation();
                        }
                        else
                        {
                            Console.WriteLine("Student array is full. Cannot add more students.");
                        }
                        break;
                    case "2":
                        DisplayStudentInformation();
                        break;
                    case "3":
                        running = !ConfirmQuit();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                        break;
                }

            } while (running);
            Console.WriteLine("goodbye!");
            

        }
        static void EnterStudentInformation()
        {
            student student = new student();

            Console.WriteLine("Ente the student name: ");
            student.Name = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Enter student age (15 to 65): ");
                string ageInput = Console.ReadLine();
                try
                {
                    age = Convert.ToSByte(ageInput);
                    if (age >= 15 && age <= 65)
                    {
                        student.Age = age;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Age must be between 15 and 65. Please try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Value is too large or too small. Please enter a value between 15 and 65.");
                }
                int id;
                while (true)
                {
                    Console.Write("Enter student ID (7 digits): ");
                    string idInput = Console.ReadLine();
                    try
                    {
                        id = Convert.ToInt32(idInput);
                        if (id >= 1000000 && id <= 9999999)
                        {
                            student.Id = id;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("ID must be a 7-digit number. Please try again.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Value is too large or too small. Please enter a valid 7-digit number.");
                    }
                }
                }
            Console.Write("Enter college name: ");
            student.CollegeName = Console.ReadLine();

            Console.Write("Enter city: ");
            student.City = Console.ReadLine();

            Console.Write("Enter address: ");
            student.Address = Console.ReadLine();
        }
        static void DisplayStudentInformation()
        {
            if (studentCount == 0)
            {
                Console.WriteLine("No student information available. Please enter information first.");
            }
            else
            {
                Console.WriteLine("\nStudent Information:");
                for (int i = 0; i < studentCount; i++)
                {
                    Console.WriteLine($"\nStudent {i + 1}:");
                    Console.WriteLine($"Name: {students[i].Name}");
                    Console.WriteLine($"Age: {students[i].Age}");
                    Console.WriteLine($"ID: {students[i].Id}");
                    Console.WriteLine($"College Name: {students[i].CollegeName}");
                    Console.WriteLine($"City: {students[i].City}");
                    Console.WriteLine($"Address: {students[i].Address}");
                }
                Console.WriteLine();
            }
        }
        static bool ConfirmQuit()
        {
            Console.Write("Are you sure you want to quit? (Y/N): ");
            string confirm = Console.ReadLine().ToUpper();
            return confirm != "y";
        }

    }
}
