using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b, c, d;
            const int number_of_element = 4;



            int[] number = new int[number_of_element];
            string[] names = new string[number_of_element]; 
            int[] numbers = { 1, 2, 3 };


            int size = number.Length;
            int size2 = numbers.Length;

            number[3] = 10;
            for(int i = 0; i < number_of_element; i++)
            {
                Console.WriteLine("Enter the number");
                number[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name");
                names[i] = (Console.ReadLine());

            }
            Console.WriteLine("INDEX\tAge\tNAME");
            for (int i = 0; i < number_of_element; i++)
            {
                Console.WriteLine(i +"\t"+number[i] +"\t" + names[i]);
            }
        }
    }
}
