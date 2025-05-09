using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    interface IFirstInterface
    {
        void myMethod(); // interface method
    } interface ISecondInterface  { 
        void myOtherMethod(); // interface method
     } // Implement multiple interfaces
      class DemoClass : IFirstInterface, ISecondInterface  { 
        public void myMethod()  
        {
            Console.WriteLine("Some text.."); 
        } 
        public void myOtherMethod()  
        { Console.WriteLine("Some other text..."); 
        } 
    }
        interface IAnimal
    {
        void animalSound(); // Interface method (does not have a body)
    }
    class Pig : IAnimal
    {
        // The body of animalSound() is provided here
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }

        // Added Run method
        public void Run()
        {
            Console.WriteLine("The pig is running!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound(); // Correct method name
            myPig.Run();         // Run method

            Console.WriteLine("**********");
            Console.ReadKey();  // Keep console open

            DemoClass myObj = new DemoClass(); myObj.myMethod(); myObj.myOtherMethod();
        }
    }
    }

