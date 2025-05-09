﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsabstact
{
    public partial class animal : Form
    {
        public animal()
        {
            InitializeComponent();
        }
        abstract class Animal
        { // Abstract method (does not have a body)
        public abstract void animalSound(); // Regular method
        public void sleep() { Console.WriteLine("Zzz"); } 
        }
          // Derived class (inherit from Animal)
          //
        class Pig : Animal { 
            public override void animalSound() { // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee"); }
        }
        class Program { static void Main(string[] args) { Pig myPig = new Pig(); // Create a Pig object
                                                          myPig.animalSound(); // Call the abstract method
                                                          myPig.sleep(); // Call the regular method
                                                             } }

            private void animal_Load(object sender, EventArgs e)
        {

        }
    }
}
