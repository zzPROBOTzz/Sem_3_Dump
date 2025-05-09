using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWF_Project.Model
{
    public class course
    {
        [Key]
        public int courseId { get; set; }
        public String courseName { get; set; }

        public virtual ICollection<teacherCourse> TeacherCourses { get; set; }
        
        public course() { }
    }
}
