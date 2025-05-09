using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public DateTime RegistrationDate { get; set; }
}

class Program
{
    static void Main()
    {
        // Step 1: Create a list of students
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, FullName = "Meet Hingu", Age = 20, Email = "meet@example.com", RegistrationDate = DateTime.Now },
            new Student { Id = 2, FullName = "Bob Patel", Age = 22, Email = "bob@example.com", RegistrationDate = DateTime.Now }
        };

        // Step 2: Display the student list in a formatted table
        Console.WriteLine("List of All Students");
        Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-25} {4,-20}", "Student Id", "Student Full Name", "Student Age", "Student Email", "Registration Date");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

        foreach (var student in students)
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-25} {4,-20}",
                student.Id,
                student.FullName,
                student.Age,
                student.Email,
                student.RegistrationDate.ToString("dd-MM-yyyy hh:mm:ss tt"));
        }
    }
}
