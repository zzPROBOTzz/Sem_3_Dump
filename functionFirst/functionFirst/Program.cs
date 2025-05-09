using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace functionFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year :");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(isLeapYear(year));

            Console.WriteLine("Enter the month number :");
            int month = int.Parse(Console.ReadLine());
            int daysInMonth = getDateInMonth(year, month);
            Console.WriteLine(getDateInMonth(month, year));
         
            Console.WriteLine($"Number of days in month {month} in year {year}: {daysInMonth}");

            Console.WriteLine("Enter number1 :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2");
            int b = int.Parse(Console.ReadLine());

            int larger =  (max(a,b));
            Console.WriteLine($"The larger number {a} and {b} is : {larger} ");

            Console.WriteLine("Enter number n :");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number max :");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number min :");
            int z = int.Parse(Console.ReadLine());

            displayNumber(x,y,z);

            Console.WriteLine("Enter the base number :");
            double baseValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Exponent :");
            int exponent = int.Parse(Console.ReadLine());

            double result = power(baseValue, exponent);
            Console.WriteLine($"Answer is : {result}");

            Console.WriteLine("Enter the number to check prime number :");
            int p = int.Parse(Console.ReadLine());

            if (isPrime(p))
            {
                Console.WriteLine($"{p} is a prime number.");
            }
            else
            {
                Console.WriteLine("it is not prime number.");
            }

            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            int digitCount = countDigit(number);
            Console.WriteLine($"{number} and count of that number {digitCount}");

            Console.WriteLine("Enter a day1");
            int day1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a day2");
            int day2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a month1");
            int month1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a month2");
            int month2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a year1");
            int year1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a year2");
            int year2 = int.Parse(Console.ReadLine());
            
            bool isFirstDayEarlier = firstDayEarlier(day1, month1, year1, day2, month2, year2);
            if (isFirstDayEarlier)
            {
                Console.WriteLine("the first date come before second");
            }
            else
            {
                Console.WriteLine("the second date comes before first");
            }
        }

        static bool isLeapYear(int year)
        {
            bool isLeapYear = false;
            if(year % 4 == 0)
            {
                isLeapYear = true;
            }
           
            return isLeapYear;
        }
        static int getDateInMonth (int month, int year)
        {
            switch (month)
            {
                case 1:  
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;

                case 2:
                    if(isLeapYear(year))
                    {
                        return 29;
                    }
                    else
                    {
                        return 30;
                    }
            }
            return month;   
        }

        static int max(int a, int b)
        {
           return (a> b) ? a : b;
        }

        static void displayNumber(int x, int y, int z) {
            if (x >= z && x<=y) {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Error");
            }
            
        }

        static double power(double baseValue, int exponent)
        {
            if(exponent == 0)
            {
                return 1;
            }
            else if (exponent < 0)
            {
                return 0;
            }
            double result = 1;
            
            for(int i = 0; i < exponent; i++)
            {
                result *= baseValue;
            }
            return result;
            

        }

        static bool isPrime(int toCheck)
        {
           if(toCheck <= 1) 
            {            
                return false;
            }

           for(int i = 2; i <= Math.Sqrt(toCheck); i++)
            {
                if(toCheck % i == 0)
                {
                    return false;
                }
            }
           return true;
        }

        static int countDigit(int d)
        {
            return d;
        }

        static bool firstDayEarlier(int day1, int month1, int year1, int day2, int month2, int year2)
        {
            if(year1  < year2)
            {
                return true;
            }
            else if(year2 == year1)
            {
                if (month1 < month2)
                { 
                   return true;
                }
                else if(month2 == month1)
                {
                    if (day2 < day1)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
    }
}
