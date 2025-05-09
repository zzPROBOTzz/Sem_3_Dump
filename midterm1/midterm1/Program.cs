using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace midterm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           // const GST_tax = 5 ;
            while (true)
            {
                Console.WriteLine("My store");
                Console.WriteLine("**********************************************");
                Console.WriteLine("1. Enter products");
                Console.WriteLine("2. Get the bill");
                Console.WriteLine("3. Exit application");
                Console.WriteLine("*********************************************");

                Console.WriteLine("Please enter your choice:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        enterProducts(); 
                        break;
                    case "2":
                        getBill();
                        break;
                    case "3":
                        Console.WriteLine("Exit application, Good bye");
                        return;
                    default:
                        Console.WriteLine("invalid input, Please enter valid option");
                        break;

                }
                void enterProducts()
                {
                    Console.WriteLine("Enter Client name: ");
                    string clientName = Console.ReadLine();
                   
                    Console.WriteLine("Enter the number of product ( greater than zero ) :");
                    int numberOfProducts;
                    while(int.TryParse(Console.ReadLine(), out numberOfProducts) && numberOfProducts <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter value greater than zero");
                    }
                    List<int> products = new List<int>();
                    for(int i = 0; i < numberOfProducts; i++)
                    {
                        Console.WriteLine($"Enter the product{i + 1} :");
                        int product;
                        while(int.TryParse(Console.ReadLine(), out product) && product < 0 && product > 500) 
                        {
                            Console.WriteLine("invalid input. Please enter number between 0 to 500");
                        }
                        products.Add(product);
                    }
                    Console.WriteLine($"products for {clientName} have been entered completely");
                }
                void getBill()
                {
                    List<int> products = new List<int>() { 100, 200, 300} ;

                    float total1 = 0;
                    foreach( int product in products)
                    {
                        total1 += product; 
                    }
                    Console.WriteLine($"total before taxes: {total1}");
                    total1 = float.Parse(Console.ReadLine());
                    float sum1 = 0;
                    foreach( int product in products)
                    {
                       sum1 += product;
                        const double QST_Tax = 9.975;
                        Console.WriteLine( "QST tax applied :" + product * QST_Tax);
                    }
                    float sum2 = 0;
                    foreach (int product in products)
                    {
                        sum2 += product;
                        const double GST_Tax = 5;
                        Console.WriteLine("GST tax applied :" + product * GST_Tax);
                    }


                    float total2 = 0;
                    foreach (int product in products)
                    {
                        total2 += product;
                        Console.WriteLine("Total prce after taxes" + total1 + QST_Tax + GST_Tax);
                    }
                    Console.WriteLine($"total before taxes: {total2}");











                }
            }
        }
    }
}
