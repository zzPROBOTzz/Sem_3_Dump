using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Experience { get; set; } // in years

        public Teacher(string name, string subject, int experience)
        {
            Name = name;
            Subject = subject;
            Experience = experience;
        }

        // Method to display teacher info
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Subject: {Subject}, Experience: {Experience} years");
        }
    }

    static void Main(string[] args)
    {
        // Step 2: Create list of teachers
        List<Teacher> teachers = new List<Teacher>();

        // Step 3: Add teacher objects
        teachers.Add(new Teacher("Alice Johnson", "Mathematics", 10));
        teachers.Add(new Teacher("Bob Smith", "Physics", 8));
        teachers.Add(new Teacher("Catherine Brown", "English", 12));
        teachers.Add(new Teacher("David Wilson", "History", 5));

        // Step 4: Get all teachers' info
        Console.WriteLine("List of Teachers:");
        foreach (var teacher in teachers)
        {
            teacher.DisplayInfo();
        }
    }
}
