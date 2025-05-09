using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_before
{
    internal class Program
    {
        public class AreaConvert
        {
            private double areaSqCm;
            private double areaSqM;
            private double areaHector;
            private double areaSqKm;

            //constructor with para
            public AreaConvert(double hector, double sqKm, double sqCm, double sqM)
            {
                areaSqCm = sqCm;               
                areaSqKm = sqKm;
                areaSqM = sqM;
                areaHector = hector;
            }

            //property for sqcm
            public double AreaSqCm  
            {
                get { return areaSqCm; }
                set { areaSqCm = value; }
            }

            //properties for sqm
            public double AreaSqm
            {
                get { return areaSqM; }
                set { areaSqM = value; }
            }
            public double AreaHector
            {
                get { return areaHector; }
                set { areaHector = value; }
            }
            public double AreaSqKm
            {
                get { return areaSqKm; }
                set { areaSqKm = value; }
            }
            public double ConvertSqCmToSqIn()
            {
                return areaSqCm * 0.155;
            }

            // Method to convert square meters to square yards
            public double ConvertSqMToSqYards()
            {
                return areaSqM * 1.19599;
            }

            public double ConvertSqMToSqAcres()
            {
                return areaHector * 2.4711;
            }

            public double ConvertSqMToSqMiles()
            {
                return areaSqKm * 0.3861;
            }

        }
        static void Main(string[] args)
        {
            AreaConvert converter;
            bool exit = false;

            do
            {
                Console.WriteLine("Choose a conversion option:");
                Console.WriteLine("1. Convert sq cm to sq in");
                Console.WriteLine("2. Convert sq m to sq yards");
                Console.WriteLine("3. Convert hectors to acres");
                Console.WriteLine("4. Convert miles to km");
                Console.WriteLine("5. Quit");

                try
                {
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Write("Enter area in sq cm: ");
                            double sqCm = double.Parse(Console.ReadLine());
                            converter = new AreaConvert(sqCm, 0,0,0);
                            Console.WriteLine($"Result: {converter.ConvertSqCmToSqIn()} sq in");
                            break;

                        case 2:
                            Console.Write("Enter area in sq m: ");
                            double sqM = double.Parse(Console.ReadLine());
                            converter = new AreaConvert(0, sqM,0,0);
                            Console.WriteLine($"Result: {converter.ConvertSqMToSqYards()} sq yards");
                            break;

                        case 3:
                            Console.Write("Enter area in sq cm: ");
                            double hector = double.Parse(Console.ReadLine());
                            converter = new AreaConvert(0, 0,hector,0);
                            Console.WriteLine($"Result: {converter.ConvertSqMToSqAcres()} sq in");
                            break;

                        case 4:
                            Console.Write("Enter area in sq m: ");
                            double sqKm = double.Parse(Console.ReadLine());
                            converter = new AreaConvert(0, 0,0,sqKm);
                            Console.WriteLine($"Result: {converter.ConvertSqMToSqMiles()} sq yards");
                            break;

                        case 5:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid option, please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            } while (!exit);
        }
        }
    }

        

    

