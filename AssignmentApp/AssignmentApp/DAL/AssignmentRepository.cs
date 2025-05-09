using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentApp.DAL
{
    public class AssignmentRepository
    {
        private AssignmentDBEntities context = new AssignmentDBEntities();

        public List<Assignment> GetAllAssignments()
        {
            return context.Assignments.ToList();
        }
        public void AddAssignment(Assignment assignment)
        {
            context.Assignments.Add(assignment);
            context.SaveChanges();
        }

        public void RemoveAssignment(int id)
        {
            List<Assignment> assignments = context.Assignments.Where(assignment => assignment.Id == id).ToList();

            foreach (Assignment assignment in assignments) 
            { 
                context.Assignments.Remove(assignment);
            }
        }

        public void updateAssignment(Assignment assignment)
        {
            Assignment updateAssignment = (Assignment)context.Assignments.Where(AssignmentDBEntities => AssignmentDBEntities.Id == assignment.Id);
            updateAssignment.Title = assignment.Title;
            updateAssignment.Description = assignment.Description;
            updateAssignment.DueDate = assignment.DueDate;
            context.SaveChanges();
        }

        public List<Assignment> GetAssignmentByTitle(string title)
        {
            return context.Assignments.Where(context => context.Title == title).ToList();
        }
        

    }
}
