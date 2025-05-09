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
    public class DepartmentService
    {
        private DepartmentRepository departmentRepository = new DepartmentRepository();

        public void addDepartment(int departmentId, string name)
        {
            if(name == "")
            {
                throw new Exception("Department name is required");
            }
            department department = new department();
            departmentRepository.addDepartment(department);

        }
        public void deleteDepartment(int departmentID)
        {
            departmentRepository.deleteDepartment(departmentID);
        }

        public DataTable getAllDepartments()
        {
            return departmentRepository.getAllDepartments();
        }


    }
}
