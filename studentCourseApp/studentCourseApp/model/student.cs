using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentCourseApp.model
{
    public class student
    {
        private int studentId;
        private string studentName;
        private string studentEmail;
        private string studentAge;
        private DateTime registrationDate;

        public student()
        {
        }

     

        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentEmail { get => studentEmail; set => studentEmail = value; }
        public string StudentAge { get => studentAge; set => studentAge = value; }
        public DateTime RegistrationDate { get => registrationDate; set => registrationDate = value; }
        public int StudentId { get => studentId; set => studentId = value; }

        public student(int studentId, string studentName, string studentEmail, string studentAge, DateTime registrationDate)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentEmail = studentEmail;
            this.studentAge = studentAge;
            this.registrationDate = registrationDate;
        }
    }
}
