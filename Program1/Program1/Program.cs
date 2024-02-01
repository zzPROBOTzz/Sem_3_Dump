using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Please enter number 1:");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter number 2:");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Please enter number 3:");
            num3 = int.Parse(Console.ReadLine());

            int sum1 = num1 + num2;
            Console.Write("sum1: ");
            Console.Write(sum1);

            int sum2 = num2 + num3;
            Console.Write("\nsum2: ");
            Console.Write(sum2);

            int sum3 = num3 + num1;
            Console.Write("\nsum3: ");
            Console.Write(sum3);

            if (sum1 == num3)
            {
                Console.Write("\nnum3 is the sum of num 1 and num 2");
            }
            else if (sum2 == num1)
            {
                Console.Write("“\nnum1 is the sum of num 2 and num 3");
            }
            else if (sum3 == num2)
            {
                Console.WriteLine("\nnum2 is the sum of num 1 and num 3");
            }
            else
            {
                Console.WriteLine("\nno solution");
            }


            Console.ReadKey();

        }
    }
}
