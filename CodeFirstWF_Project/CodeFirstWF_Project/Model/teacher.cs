using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWF_Project.Model
{
    public class teacher
    {
        [Key]
        public int teacherId { get; set; }
        public string firstName { get; set; }
        public string lastName {  get; set; }
       

        public teacher() { }


        public virtual ICollection<teacherCourse> TeacherCourses { get; set; }
    }
}
