using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtest
{
     class Box
    {
        private double length; // Length of a box
        private double breadth; // Breadth of a box
        private double height; // Height of a box

        public void setLength(double len) { length = len; }
        public void setBreadth(double bre) { breadth = bre; }
        public void setHeight(double hei) { height = hei; }
        public double getVolume() { return length * breadth * height; }
        }
    class Line
    {
        public double length;
        public Line() { Console.WriteLine("Object is being created"); }
        public void setLength(double len) { length = len; }
        public double getLength() { return length; }
    }
        class Boxtester
        {
            static void Main(string[] args)
            {
            Line line = new Line();
           

            // set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}" , line.getLength());
            Console.ReadKey();

            Box Box1 = new Box(); // Declare Box1 of type Box
                Box Box2 = new Box();
                double volume;

                // Declare Box2 of type Box
                // box 1 specification
                Box1.setLength(6.0);
                Box1.setBreadth(7.0);
                Box1.setHeight(5.0);

                // box 2 specification
                Box2.setLength(12.0);
                Box2.setBreadth(13.0);
                Box2.setHeight(10.0);

                // volume of box 1
                volume = Box1.getVolume();
                Console.WriteLine("Volume of Box1 : {0}", volume);

                // volume of box 2
                volume = Box2.getVolume();
                Console.WriteLine("Volume of Box2 : {0}", volume);

                Console.ReadKey();
            }
        }
    }
    

