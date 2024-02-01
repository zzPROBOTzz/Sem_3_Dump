using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f;
            double c;

            Console.WriteLine("Enter temperature in degrees Fahrenheit:");
            f = double.Parse(Console.ReadLine());

            c = (f - 32) * 5 / 9;
            Console.WriteLine("Result" + c);
            c = double.Parse(Console.ReadLine());
        }
    }
}
