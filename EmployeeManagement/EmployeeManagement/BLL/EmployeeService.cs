using EmployeeManagement.DAL;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BLL
{
    public class EmployeeService
    {
        private EmployeeRepository employeeRepository = new EmployeeRepository();

        public void addEmployee(int employeeId, string name, string email)
        {
            if (name == "")
            {
                throw new Exception("Employee name is required");
            }
            if (email == "")
            {
                throw new Exception("Employee email is required");
            }
            

            employee employee = new employee();
            employeeRepository.addEmployee(employee);
        }
        public void deleteEmployee(int employeeID)
        {
            employeeRepository.deleteEmployee(employeeID);
        }

        public DataTable getAllEmployees()
        {
            return employeeRepository.getAllEmployees();
        }
    }
}
