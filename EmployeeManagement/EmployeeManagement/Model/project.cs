using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class project
    {
        private int projectID;
        private string projectName;
        
        public project()
        { }

        public int ProjectID { get => projectID; set => projectID = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
    }
}
