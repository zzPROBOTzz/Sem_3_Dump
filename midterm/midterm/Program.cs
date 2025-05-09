using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable
            int option = 0, numOfGrades = 0;
            double sumOfGrades = 0;
            string studentName = "";
            double QST_tax = 0.0854;
            double GST_tax = 0.0435;

            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("*****************************************");
                Console.WriteLine("1. Enter products");
                Console.WriteLine("2. get the bill");
                Console.WriteLine("3. Exit application");
                Console.WriteLine("**************************************");
                Console.WriteLine("Enter your choice.");

                while(!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Please enter an integer number again:");
                }
                switch(option)
                {
                    case 1:
                        Console.WriteLine("1. Enter the client detail");
                        sumOfGrades = 0;
                        studentName = "";
                        Console.WriteLine("Please enter the student name: ");
                        while(string.IsNullOrEmpty(studentName))
                        {
                            Console.WriteLine("Please enter the name again:");
                            studentName = Console.ReadLine();
                        }

                        Console.WriteLine("please enter the number of products :");
                        while(!int.TryParse(Console.ReadLine(),out numOfGrades) || numOfGrades < 0)
                        {
                            Console.WriteLine("Please enter an integer number again:");
                        }
                        int product = 0;
                        for(int i = 0; i < numOfGrades; i++)
                        {
                            Console.Write($"Please enter the PRODUCT # {i + 1}: ");
                            while(!int.TryParse(Console.ReadLine(), out product)|| product < 0)
                            {
                                Console.Write("Please enter an integer number again: ");
                            }
                            sumOfGrades += product;
                        }
                        break;
                    case 2:
                        Console.WriteLine("2. Display bill");
                        Console.WriteLine("client Name:" + studentName);
                        double total1 = QST_tax * sumOfGrades;
                        double total2 = total1 + sumOfGrades;
                        Console.WriteLine($"bill with QST: {total2} ");

                        double total3 = GST_tax * sumOfGrades;
                        double total4 = total3 + sumOfGrades;
                        Console.WriteLine($"bill with GST: {total4} ");

                        double total6 = (QST_tax + GST_tax) * sumOfGrades;
                        Console.WriteLine($"Average: {total6} ");

                        break;
                }
            }

        }
    }
}
            

        
    
