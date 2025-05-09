using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWF_Project.Model
{
    public class teacherCourse
    {
        [Key]
        public int assignId { get; set; }
        public int teacherId { get; set; }
        public int courseId { get; set; }

        [ForeignKey("teacherId")]
        public teacher teacher { get; set; }

        

        [ForeignKey("courseId")]
        public course course { get; set; }

        public teacherCourse() { }
    }
}
