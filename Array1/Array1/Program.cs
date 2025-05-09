using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int number_of_element = 4;
            int[] number = new int[number_of_element];
            string[] names = new string[number_of_element];
            int option = 0;
            bool namesCreated = false;
            bool numberCreated = false;



            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("**********************************************");
                Console.WriteLine("1. Enter the Names");
                Console.WriteLine("2. Enter the age");
                Console.WriteLine("3. display the table");
                Console.WriteLine("4. Max and min age");
                Console.WriteLine("5. Average age");
                Console.WriteLine("6. show the single index");
                Console.WriteLine("7. exit application");
                Console.WriteLine("**********************************************");

                Console.Write("Enter your choice: ");
                option = int.Parse(Console.ReadLine());             

                switch (option)
                {
                    case 1:
                        for (int i = 0; i < number_of_element; i++)
                        {
                            
                            Console.Write($"Enter the name #{i + 1} : ");
                            names[i] = (Console.ReadLine());
                        }

                        namesCreated = true;


                        break;
                    case 2:
                        for (int i = 0; i < number_of_element; i++)
                        {
                            Console.Write($"Enter the age #{i + 1} : ");
                            number[i] = int.Parse(Console.ReadLine());
                        }

                        numberCreated = true;

                        break;
                    case 3:
                        if(!numberCreated || !namesCreated)
                        {
                            Console.WriteLine("Please enter names and ages");
                        }
                        else
                        {
                            Console.WriteLine("INDEX\tAge\tNAME");
                            for (int i = 0; i < number_of_element; i++)
                            {
                                Console.WriteLine(i + "\t" + number[i] + "\t" + names[i]);
                            }
                        }
                       

                        break;
                    case 4:
                        int min = number[0];
                        int max = number[0];

                        for(int i = 0; i < number.Length - 1; i++)
                        {

                            if (number[i] > max)
                            {
                                max = number[i];
                            }
                            if (number[i] < min)
                            {
                                min = number[i];
                            }
                        }
                        Console.WriteLine("Minimum age: " + min);
                        Console.WriteLine("Maximum age: " + max);
                        break;

                    case 5:
                        double avg = number.Average();

                        Console.WriteLine("Average =" + avg);

                        
                        break;
                    case 6:
                        Console.WriteLine("Enter the specific index");
                        if(int.TryParse(Console.ReadLine(), out int displayIndex) && displayIndex >= 0 && displayIndex < names.Length)
                        {
                            Console.WriteLine($"Name of Index {displayIndex}: Name : {names[displayIndex]} "+"\t" + $"Age : {number[displayIndex]}");
                        }
                        else
                        {
                            Console.WriteLine("Wrong index number");
                        }
                        break;
                    case 7:
                        Console.Write("bye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
