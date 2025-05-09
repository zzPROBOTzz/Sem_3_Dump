using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args, int upperLimit)
        {
            //VARIABLES
            int exercise = 0;
            double min, max, number;
            int num;
            long factorial = 1;
            int lowerLimit, upperLimit;
          
            //CONSTANTS

            //while (exercise < 20) //this is another way to exit the program
            while (true)
            {
                Console.WriteLine("Type the number of the exercise you want execute");
                //Console.WriteLine("or a number greather than 20 to exit"); //this is another way to exit the program
                exercise = Convert.ToInt32(Console.ReadLine());

                switch (exercise)
                {
                    case 1:
                        Console.WriteLine("***** Exercise 1 *******");

                        // here your code
                        Console.WriteLine("Please enter minimun number");
                        min = double.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter maximum number");
                        max = double.Parse(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Please enter a number ");
                            number = double.Parse(Console.ReadLine());
                        } while (number < min || number > max);
                        //while (number < min || number > max)
                        //{
                        //    Console.WriteLine("Please enter a number ");
                        //    number = double.Parse(Console.ReadLine());
                        // }
                        Console.WriteLine($"Yes {number} is between {min} and {max}");

                        break;
                    case 2:
                        Console.WriteLine("***** Exercise 2 *******");

                        // here your code
                        Console.WriteLine("Enter an integer: ");
                        num = int.Parse(Console.ReadLine());


                        if (num < 0)
                        {
                            Console.WriteLine("Enter a positive.");
                            num = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            int i = 1;
                            do
                            {
                                factorial *= i;
                                i++;
                            } while (i <= num);
                        }
                        Console.WriteLine($"Factorial {num} is :{factorial}" );
                       
                        break;
                    case 3:
                        Console.WriteLine("***** Exercise 3 *******");

                        // here your code

                        do
                        {
                            Console.WriteLine("Enter a mininum number");
                            lowerLimit = int.Parse(Console.ReadLine());
                        } while (lowerLimit <= 0);
                        do
                        {
                            Console.WriteLine("Enter a maximun number");
                            upperLimit = int.Parse(Console.ReadLine());
                        } while (upperLimit >= lowerLimit);
    
                        int sum = 1;
                        int j = lowerLimit;
                        do
                        {
                            sum += j;
                            j++;
                        } while (j <= upperLimit);

                        Console.WriteLine($"Output is:{sum}");
                        

                        break;
                    default:
                        Console.WriteLine("Wrong option, please try again.");
                        Console.ReadLine();
                        break;
                }

                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}