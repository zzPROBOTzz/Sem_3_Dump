using EmployeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BLL
{
    public class ProjectService
    {
        private ProjectRepository projectRepository = new ProjectRepository();

        public void addProject(int projectID, string projectName)
        {
            if (projectName == "")
            {
                throw new Exception("Project name is required");
            }
            Model.project project = new Model.project();
            project.ProjectName = projectName;
        }

        public DataTable getAllProjects()
        {
            return projectRepository.getAllProjects();
        }
    }


}


