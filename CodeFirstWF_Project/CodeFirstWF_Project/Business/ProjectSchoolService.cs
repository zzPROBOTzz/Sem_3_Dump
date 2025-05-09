using CodeFirstWF_Project.DataAccess;
using CodeFirstWF_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstWF_Project.Business
{
    public class ProjectSchoolService
    {
        ProjectDbContext dbContext = new ProjectDbContext();

        public void addCourse(int courseId, String courseName)
        {
            var course = new course();
            course.courseId = courseId;
            course.courseName = courseName;

            dbContext.Courses.Add(course);
            dbContext.SaveChanges();
        }

        public List<course> showCourses()
        {
            return dbContext.Courses.ToList();
        }

        public void addTeacher(int teacherId, String firstName, String lastName) 
        {
            var teacher = new teacher();
            teacher.teacherId = teacherId;
            teacher.firstName = firstName;
            teacher.lastName = lastName;

            dbContext.Teachers.Add(teacher);
            dbContext.SaveChanges();
        }

        public List<teacher> showTeachers()
        {
            return dbContext.Teachers.ToList();
        }

        public bool assignCourses(int assignId, int courseId, int teacherId)
        {
            var assignCourse = new teacherCourse();
            assignCourse.courseId = courseId;
            assignCourse.teacherId = teacherId;
            assignCourse.assignId = assignId;

            dbContext.TeachersCourse.Add(assignCourse);

           
            return true;

        }

        public List<teacherCourse> showAssignCourse()
        {
            return dbContext.TeachersCourse.ToList();
        }

        // for user login
        public user userLogin(String  username, String password)
        {
            return dbContext.Users.FirstOrDefault(u => u.username == username && u.password == password);
        }

        public bool AssignMaxTeacher(int courseId, int teacherId, int assignId)
        {
            int course = dbContext.TeachersCourse.Where(tc => tc.teacherId == teacherId).Count();

            if (course >= 4) 
            {
                MessageBox.Show("Teacher can be assigned 4 courses..");
                return false;
            }
            return true;
        }
    }
}
