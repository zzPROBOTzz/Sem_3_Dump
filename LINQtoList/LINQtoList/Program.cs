using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoList
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    public class Program
    {


        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice Johnson", Department = "HR", Salary = 55000 },
            new Employee { Id = 2, Name = "Bob Smith", Department = "IT", Salary = 75000 },
            new Employee { Id = 3, Name = "Charlie Brown", Department = "Finance", Salary = 68000 },
            new Employee { Id = 4, Name = "David Williams", Department = "Marketing", Salary = 60000 },
            new Employee { Id = 5, Name = "Emma Wilson", Department = "IT", Salary = 80000 },
            new Employee { Id = 6, Name = "Franklin Scott", Department = "Finance", Salary = 70000 },
            new Employee { Id = 7, Name = "Grace Miller", Department = "HR", Salary = 52000 },
            new Employee { Id = 8, Name = "Hank Green", Department = "Marketing", Salary = 59000 },
            new Employee { Id = 9, Name = "Isabella Adams", Department = "IT", Salary = 78000 },
            new Employee { Id = 10, Name = "Jack White", Department = "Finance", Salary = 72000 }
        };

            var highSalaryEmployees = from employee in employees where employee.Salary > 60000 select employee.Name;
            Console.WriteLine("Employees with Salary above $60,000:");
            foreach (var emp in highSalaryEmployees)
            {
                // Console.WriteLine($"{emp.Name} - ${emp.Salary}");
                Console.WriteLine("Employee Name: " + emp);
            }

            var employeeNamesAndDepartments = employees.Select(e => new { e.Name, e.Department });
            Console.WriteLine("Employee Names and Departments:");
            foreach (var emp in employeeNamesAndDepartments)
            {
                Console.WriteLine($"{emp.Name} - {emp.Department}");
            }

            var orderedBySalary = from employee in employees orderby employee.Salary select employee.Salary;
            Console.WriteLine("Employees Ordered by Salary:");
            foreach (var emp in orderedBySalary)
            {
                Console.WriteLine("Employee salary:" + emp);
            }
        }
    
    }

}



