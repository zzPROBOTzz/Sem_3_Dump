using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_consoleapp
{
    public class Program
    {       
        public class LengthConvert
        {
            //private fields
            private double meters;
            private double kilometers;

            //cunstrustor for meter
            public LengthConvert(double meters)
            {
                Meters = meters;
            }

            //construstor for km
            public LengthConvert(double kilometers, bool isKilometers) 
            {
                Kilometers = kilometers;
                
            }
            //property for kilometer
            public double Kilometers
            {
                get { return kilometers; }
                set { kilometers = value; }
            }

            //property for meter
            public double Meters
            {
                get { return meters; }
                set { meters = value; }
            }

            //method to convert meter to centimeter
            public double mtocm()
            {
                return Meters * 100;
            }
            //method to convert kilometer to meter
            public double kmtom()
            {
                return Kilometers * 1000;
            }
            //method to conert meter to yards
            public double mtoyd()
            {
                return Meters * 1.0936;
            }
            //method to convert kilometer to miles
            public double kmtoml()
            {
                return Kilometers * 0.6214;
            }
            public void DisplayResults(double mValue)
            {
                Console.WriteLine($"For {mValue} m : {mtocm()} cm and {mtoyd()}yd");
            }
            public void DisplayResultsKm(double kmValue)
            {
                Console.WriteLine($"For {kmValue} km : {kmtom()} meter and {kmtoml()}miles");
            }
        }

        static void Main(string[] args)
        {
            bool Conversion = true;

            do
            {
                Console.WriteLine("Length Conversion Menu:");
                Console.WriteLine("1.COnvert Meters to centemeters and yards.");
                Console.WriteLine("2.convert Kilometers to meters and miles.");
                Console.WriteLine("3.Quit");
                Console.WriteLine("Select the Option:");

                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());
                    double length;

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine(txtBox2);
                            length = Convert.ToDouble(Console.ReadLine());
                            LengthConvert meterConvert = new LengthConvert(length);
                            meterConvert.DisplayResults(length);
                            break;
                        case 2:
                            Console.WriteLine("Enter the length in Kilometers: ");
                            length = Convert.ToDouble(Console.ReadLine());
                            LengthConvert kilometerConvert = new LengthConvert(length, true);
                            kilometerConvert.DisplayResultsKm(length);
                            break;
                        case 3:
                            Conversion = false;
                            break;
                        default:
                            Console.WriteLine("invalid option please select 1-3");
                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid input");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error accured");
                }
                Console.WriteLine();

            }while(Conversion);
        }
    }
}
