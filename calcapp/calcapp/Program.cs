using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    class Calc
    {
        // Private fields
        private double number1;
        private double number2;

        public double Number1
        {
            get { return number1; }
            set { number1 = value; }
        }

        public double Number2
        {
            get { return number2; }
            set { number2 = value; }
        }

        // Default constructor
        public Calc()
        {
            number1 = 0;
            number2 = 0;
        }

        // Overloaded constructor with two parameters
        public Calc(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }

        // Method to add the numbers
        public double Add()
        {
            return number1 + number2;
        }

        // Method to subtract the numbers
        public double Sub()
        {
            return number1 - number2;
        }

        // Method to multiply the numbers
        public double Mul()
        {
            return number1 * number2;
        }

        // Method to divide the numbers
        public double Div()
        {
            if (number2 != 0)
            {
                return number1 / number2;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
                return double.NaN; // Not a number if division by zero
            }
        }

        // Method to display results similar to the image
        public void Display(string constructorType)
        {
            Console.WriteLine($"\nConstructor: {constructorType}");
            Console.WriteLine($"number1={number1}, number2={number2}, res=0, info=0 (NaN = not a number)\n");

            Console.WriteLine($"Your numbers are: {number1} & {number2}");
            Console.WriteLine("======================================Results=====================================");
            Console.WriteLine($"/t{number1} + /t{number2} = /t{Add()}");
            Console.WriteLine($"/t{number1} - /t{number2} = /t{Sub()}");
            Console.WriteLine($"/t{number1} * /t{number2} = /t{Mul()}");
            if (number2 != 0)
            {
                Console.WriteLine($"/t {number1} / /t{number2} = /t{Div()}");
            }
            Console.WriteLine("=================================================================================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Calc object using the default constructor
            Calc calc1 = new Calc();
            double num1 = 0, num2 = 0;

            // Getting user input for the first object
            Console.WriteLine("Please enter the first number: ");
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numerical values.");
                return;
            }

            // Set the values using properties
            calc1.Number1 = num1;
            calc1.Number2 = num2;

            // Display results for default constructor
            calc1.Display("Default constructor using default values");

            // Create the second Calc object using the overloaded constructor
            Calc calc2 = new Calc(9, 3);

            // Display results for overloaded constructor
            calc2.Display("Constructor with two arguments for number1=9 and number2=3");

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}


