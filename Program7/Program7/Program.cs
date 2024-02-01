using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double baseSalary = 400;
            const double commissionPerVehicle = 200;
            const double bonusRate = 0.05;

            Console.WriteLine("Enter the number of vehicles sold: ");
            int vehicleSold = int.Parse(Console.ReadLine());

            double commission = vehicleSold * commissionPerVehicle;
            Console.WriteLine("commission" + commission);
            commission = double.Parse(Console.ReadLine());

            double totalSalesAmount = baseSalary + commission;  
            Console.WriteLine("totalSalesAmount" + totalSalesAmount);
            totalSalesAmount = double.Parse(Console.ReadLine());

            double bonus = totalSalesAmount * bonusRate;
            Console.WriteLine("bonus" + bonus);
            bonus = double.Parse(Console.ReadLine());   

            double totalCompensation = baseSalary + commission + bonus;
            Console.WriteLine(totalCompensation);
            totalCompensation = double.Parse(Console.ReadLine());   


        }
    }
}
