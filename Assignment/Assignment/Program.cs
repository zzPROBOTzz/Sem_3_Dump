using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new schoolEntities();

            Console.WriteLine("Students:");
            var students = context.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName + "\t" + student.LastName + "\t" + student.Email);
            }

           Console.WriteLine("\nInstructors:");
            var instructors = context.Instructors.ToList();
            foreach (var instructor in instructors)
            {
                Console.WriteLine(instructor.FirstName + "\t" + instructor.LastName);
            }

            Console.WriteLine("\nCourses:");
            var courses = context.Courses.ToList();
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " " + "is taught by " + course.Instructor.FirstName );
            }

            Console.WriteLine("\nEnrollments:");
            var enrollments = context.Enrollments.ToList();
            foreach (var enrollment in enrollments)
            {
                Console.WriteLine(enrollment.Student.FirstName + " " + enrollment.Student.LastName + " is enrolled in " + enrollment.Cours.CourseName);
            }
            Console.ReadLine();
        }
    }
}
