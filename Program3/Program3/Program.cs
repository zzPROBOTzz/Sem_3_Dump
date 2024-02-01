using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean isHead1 = true;
            Boolean isHead2 = true;

            int bothHead = 10;
            int oneHead = 5;

            Console.WriteLine("please enter the result of the game");
            Console.WriteLine("The player 1 got a head?");
            Console.ReadKey(isHead1);
            Console.WriteLine("The player 2 got a head?");
            Console.ReadKey(isHead2);

            if(isHead1 && isHead2)
            {
                Console.WriteLine("Both players win" + bothHead);
                Console.ReadLine();

            }
            else if(isHead1)
            {
                Console.WriteLine("Player 1 win " + oneHead);
                Console.ReadLine();
            }
            else if(isHead2)
            {
                Console.WriteLine("Player 2 win" + oneHead);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nobody wins");   
                Console.ReadLine();
            }
        }
    }
}
