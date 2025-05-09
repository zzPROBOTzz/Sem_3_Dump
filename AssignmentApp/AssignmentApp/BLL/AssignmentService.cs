using AssignmentApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentApp.BLL
{
    public class AssignmentService
    {
        private AssignmentRepository repository = new AssignmentRepository();

        public List<Assignment> GetAllAssignments()
        {
            return repository.GetAllAssignments();
        }

        public void AddAssignment(int id, string title, string description, DateTime dueDate)
        {
            Assignment newAssignment = new Assignment();
            newAssignment.Id = id;
            newAssignment.Title = title;
            newAssignment.Description = description;
            newAssignment.DueDate = dueDate;    

            repository.AddAssignment(newAssignment);

        }

        public void DeleteAssignment(int id) {

            repository.RemoveAssignment(id);
        }

        public void updateAssignment(int id, string title, string description, DateTime dueDate)
        {
            Assignment updateAssignment = new Assignment();
            updateAssignment.Id = id;
            updateAssignment.Title = title;
            updateAssignment.Description = description;
            updateAssignment.DueDate = dueDate;

            repository.updateAssignment(updateAssignment);
        }

        public List<Assignment> GetAssignmentByTitle(string title)
        {
            return repository.GetAssignmentByTitle(title);
        }
    }
}
