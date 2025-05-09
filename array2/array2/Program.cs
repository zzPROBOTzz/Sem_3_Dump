using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] students = new string[10,6];
            int option;
            int count = 0;




            while (true)
            {
                Console.WriteLine("MY STUDENTS");
                Console.WriteLine("**********************************************");
                Console.WriteLine("1. Enter the Data");
                Console.WriteLine("2. Enter the Grades");
                Console.WriteLine("3. display the table");
                Console.WriteLine("4. show the single index");
                Console.WriteLine("5. Average of group");
                Console.WriteLine("6. get best student");
                Console.WriteLine("7. exit application");
                Console.WriteLine("**********************************************");

                Console.Write("Enter your choice: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        if(count >= students.GetLength(0))
                        {
                            Console.WriteLine("Maximum number of students reached.");
                        }
                        else
                        {
                            Console.WriteLine("Enter student id :");
                            students[count,0] = Console.ReadLine();

                            Console.WriteLine("Enter First Name");
                            students[count,1] = Console.ReadLine();

                            Console.WriteLine("Enter Last name");
                            students[count,2] = Console.ReadLine();

                            count++;
                            Console.WriteLine("Information entered successfully");
                        }
                    

                        break;
                    case 2:
                        if(!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            Console.WriteLine("Enter Midterm marks :");
                            students[count, 3] = Console.ReadLine();

                            Console.WriteLine("Enter Final Project marks :");
                            students[count, 4] = Console.ReadLine();

                            Console.WriteLine("Enter Final Exam marks :");
                            students[count, 5] = Console.ReadLine();

                            count++;
                            Console.WriteLine("Information entered successfully");
                        }
                        break;
                    case 3:
                        Console.WriteLine("All students info. :");
                        for(int i = 0;i < count; i++)
                        {
                            Console.WriteLine($"Row {i}");
                            Console.WriteLine($"Student Id : {students[i, 0]}");
                            Console.WriteLine($"First Name : {students[i, 1]}");
                            Console.WriteLine($"Last Name : {students[i, 2]}");
                            Console.WriteLine($"Grades of midterm : {students[i, 3]}, grade of project{students[i,4]}, Grade of final exam : {students[i,5]}");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Enter the id you want to search: ");
                        string id = Console.ReadLine();

                        bool found = false;
                        for(int i = 0;i < count; i++)
                        {
                            if (students[i, 0] == id)
                            {
                                Console.WriteLine($"Row {i}");
                                Console.WriteLine($"Student Id : {students[i, 0]}");
                                Console.WriteLine($"First Name : {students[i, 1]}");
                                Console.WriteLine($"Last Name : {students[i, 2]}");
                                Console.WriteLine($"Grades of midterm : {students[i, 3]}, grade of project{students[i, 4]}, Grade of final exam : {students[i, 5]}");
                                found = true;
                                break;

                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Invalid student id");
                        }
                        break;
                    case 5:
                        double totalGrade = 0;

                        for(int i=0; i < count; i++)
                        {
                            if (double.TryParse(students[i, 3], out double midterm) &&
                                double.TryParse(students[i, 4], out double project) &&
                                double.TryParse(students[i, 5], out double finalExam))
                            {
                                double finalGrade = (midterm * 0.3) + (project* 0.3) +(finalExam * 0.4);
                                totalGrade += finalGrade;
                            }
                        }

                        double averageGroup = totalGrade / count;
                        Console.WriteLine($"Average of the Group : {averageGroup}");
                        break;
                    case 6:
                        double bestGrade = 0;
                        string bestStudentId = "";
                        string bestFirstName = "";
                        string bestLastName = "";

                        for(int i = 0; i < count; i++)
                        {
                            if (double.TryParse(students[i, 3], out double midterm) &&
                               double.TryParse(students[i, 4], out double project) &&
                               double.TryParse(students[i, 5], out double finalExam))
                            {
                                double finalGrade = (midterm * 0.3) + (project * 0.3) + (finalExam * 0.4);
                                if(finalGrade > bestGrade)
                                {
                                    bestGrade = finalGrade;
                                    bestStudentId = students[i, 0];
                                    bestFirstName = students[i, 1];
                                    bestLastName = students[i, 2];
                                }
                            }
                        }
                        if(bestGrade > 0)
                        {
                            Console.WriteLine($"Best student : ");
                            Console.WriteLine($"Student Id : {bestStudentId}");
                            Console.WriteLine($"Name: {bestFirstName} {bestLastName} ");
                            Console.WriteLine($"Final Grade : {bestGrade} ");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice, please try again");
                        }
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;



                  
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
