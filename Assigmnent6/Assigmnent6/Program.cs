using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmnent6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Please enter a number");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
            {
                int product = 1;

                for(int i = 1; i <= n; i += 2)
                {
                    product *= i;
                }

                Console.WriteLine($"The product of all odd numbers between 1 and {n} is: {product}");

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than or equal to 1.");
            }

            */
            Console.WriteLine("Enter the width of the parallelogram:");
            int width;

            // Validate and read user input for width
            while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the width:");
            }

            Console.WriteLine("Enter the height of the parallelogram:");
            int height;

            // Validate and read user input for height
            while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the height:");
            }

            // Draw the parallelogram
            Console.WriteLine("\nParallelogram:");

            for (int i = 0; i < height; i++)
            {
                // Print spaces for indentation
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks for the parallelogram
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }
    }
}
