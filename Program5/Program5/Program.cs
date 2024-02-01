using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double GSTrate = 0.07;
            double QSTrate = 0.075;

            Console.WriteLine("Enter the unit price of the product: $");
            double unitPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the quantity purchased:");
            int quantity = int.Parse(Console.ReadLine());

            double GST = unitPrice * GSTrate;
            Console.WriteLine("Amount for GST: $" + GST);
            GST = Double.Parse(Console.ReadLine()); 

            double QST = unitPrice + GST * QSTrate;
            Console.Write("Amount for QST: $" + QST);
            QST = Double.Parse(Console.ReadLine());

            double totalPrice = unitPrice * quantity + QST + GST;
            Console.WriteLine("Total price after Taxes: $" + totalPrice);
            totalPrice = Double.Parse(Console.ReadLine());
        }
    }
}
