using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab4._1
{
    struct StudentS
    {
        public string name;
        public sbyte age;
        public uint id;
        public string college_name;
        public string city;
        public string addredss;

        //method 
        //public StudentS() { }
        public StudentS(string names,sbyte ages, uint ids, string college_names, string city, string address) {

            this.name = names;
            this.age = ages;
            this.id = ids;
            this.college_name = college_names;
            this.city = city;
            this.addredss = address;
        }
         
    }

    class StudentC
{
    public string name;
    public sbyte age;
    public uint id;
    public string college_name;
    public string city;
    public string addredss;

    public StudentC() { }
    
    public StudentC(string name)
        {
            name = name;
        }
    public StudentC(string name, sbyte age, uint id, string college_name, string city, string address) { 
        this.name = name;
        this.age = age;
        this.id = id;
        this.college_name = college_name;  
        this.city = city;
        this.addredss = address;
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
        StudentC sc0 = new StudentC();
        StudentS ss0 = new StudentS();

        StudentS ss1 = new StudentS("Struct1", 10,123456,"laslalle","3434vll","23255ffeef");
        }
    }
}
