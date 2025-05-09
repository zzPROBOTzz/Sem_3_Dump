using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Calc
    {
        //class member
        //private fields
        decimal num1;
        decimal num2;
        //public properties
        public decimal Num1 { get { return Num1; } set { Num1 = value; } }

        public decimal Num2 { get { return Num2; } set { Num2 = value; } }
        //public constractor
        public Calc() { }
        public Calc(decimal num1, decimal num2)
        {
            Num1 = num1;
            this.num2 = num2;
        }
        //public method
        public decimal Add()
        {
            return num1 + num2;
        }
        public decimal Sub()
        {
            return num1 - num2;
        }
        public decimal Mul()
        {
            return num1 * num2;
        }
        public decimal Div()
        {
            return num1 / num2;
        }
    }
}
