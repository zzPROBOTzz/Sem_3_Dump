using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Meet Hingu
// 11-09-2024
//assignent 1

namespace program01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int num = int.Parse(Console.ReadLine());

            int nxt_val = num + 1;
            int prv_val = num - 1;

            Console.WriteLine("the next number is :" + nxt_val);
            Console.WriteLine("the previous number is:" + prv_val);


            Console.WriteLine("enter number 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2");
            int num2 = int.Parse(Console.ReadLine());

            int addition = num1 + num2;
            Console.WriteLine("addition =" + addition);

            int multi = num1 * num2;
            Console.WriteLine("Multiplication =" + multi);

            int division = num1 / num2;
            Console.WriteLine("division =" + division);

            int sub = num1 - num2;
            Console.WriteLine("subctraction =" + sub);
        }
    }
}
