using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type the number of the exercise you want execute");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enter a number");
                        if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
                        {
                            int product = 1;

                            for (int i = 1; i <= n; i += 2)
                            {
                                product *= i;
                            }

                            Console.WriteLine($"The product of all odd numbers between 1 and {n} is: {product}");

                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number greater than or equal to 1.");
                        }



                        break;
                    case 2:
                        Console.WriteLine("Enter the width of the parallelogram:");
                        int width;

                        
                        while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer for the width:");
                        }

                        Console.WriteLine("Enter the height of the parallelogram:");
                        int height;

                       
                        while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer for the height:");
                        }

                       
                        Console.WriteLine("\nParallelogram:");

                        for (int i = 0; i < height; i++)
                        {
                           
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write(" ");
                            }

                           
                            for (int j = 0; j < width; j++)
                            {
                                Console.Write("*");
                            }

                            Console.WriteLine();

                        }         

                        break;
                    case 3:
                       
                        Console.WriteLine("Enter a positive number (n) :");
                        n = int.Parse(Console.ReadLine());

                        while(!int.TryParse(Console.ReadLine(),out n) || n <= 0)
                        {
                            Console.WriteLine("Invalid input, Please enter a positive number:");
                        }
                        string binaryNumber = convertToBinary(n);

                        Console.WriteLine($"Binary numbber of {n}:{binaryNumber}");

                        string convertToBinary(int number)
                        {

                            return Convert.ToString(number, 2);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter 10 numbers:");

                        int[] numbers = new int[10];
                        for(int i=0; i< 10; i++)
                        {
                            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number:");
                            }
                        }
                        bool foundSequence = false;
                        for (int i = 0; i < 8; i++)
                        {
                            if (numbers[i] + 1 == numbers[i + 1] && numbers[i + 1] + 1 == numbers[i + 2])
                            {
                                foundSequence = true;
                                break;
                            }
                        }
                        if (foundSequence)
                        {
                            Console.WriteLine("There are three adjacent numbers meeting the condition.");
                        }
                        else
                        {
                            Console.WriteLine("No three adjacent numbers meeting the condition found.");
                        }

                        break;

                    default:
                        Console.WriteLine("Wrong option, please try again.");
                        break;
                }
            }
        }
       
    }
}
