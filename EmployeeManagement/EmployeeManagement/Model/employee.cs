using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class employee
    {
    
        private int EmployeeID;
        private string Name;
        private string Email;
        private int DepartmentID;

        public employee()
        { }

        public int employeeID { get => EmployeeID; set => EmployeeID = value; }
        public string name { get => Name; set => Name = value; }
        public string email { get => Email; set => Email = value; }
        public int departmentID { get => DepartmentID; set => DepartmentID = value; }
    }
}
