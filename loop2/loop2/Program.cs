using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Start the program");
            for (int i = n; i < 5; i++)
            {
                for(int j=i; j>=i; j--)
                {
                    Console.WriteLine("\n*");
                }
               Console.WriteLine("\n*");
            }
            Console.WriteLine("End the program");
        }
    }
}
