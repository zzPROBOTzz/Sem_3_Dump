using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentGrade;
            float maxGradeF = 60;
            float maxGradeD = 70;
            float maxGradeC = 80;
            float maxGradeB = 90;


            Console.WriteLine("Please enter the student grade");
            studentGrade = Convert.ToInt32(Console.ReadLine());

            if (studentGrade < maxGradeF)
            {
                Console.WriteLine("F");
                Console.ReadLine();
            }
            else if (studentGrade < maxGradeD)
            {
                Console.WriteLine("D");
                Console.ReadLine();
            }
            else if (studentGrade < maxGradeC)
            {
                Console.WriteLine("C");
                Console.ReadLine();
            }
            else if (studentGrade < maxGradeB)
            {
                Console.WriteLine("B");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("A");
                Console.ReadLine();

            }
        }
    }
}
