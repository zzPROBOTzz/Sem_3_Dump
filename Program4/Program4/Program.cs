using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int side1;
            int side2;  
            int side3;

            Console.WriteLine("Please enter the side 1");
            side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the side 2");
            side2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the side 3");
            side3 = int.Parse(Console.ReadLine());

            if (side1 == side2 && side1 == side3)
            {
                Console.WriteLine("Equilateral");
                Console.ReadLine();
            }
            else if(side1 == side2 ||  side1 == side3 || side2 == side3)
            {
                Console.WriteLine("Isosceles");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Scalene");
                Console.ReadLine();
            }
        }
    }
}
