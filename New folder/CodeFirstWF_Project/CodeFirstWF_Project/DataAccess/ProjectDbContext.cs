using CodeFirstWF_Project.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWF_Project.DataAccess
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext() : base("SchoolEFDB") { }

        public DbSet<course> Courses { get; set; }
        public DbSet<teacher> Teachers { get; set; }
        public DbSet<user> Users { get; set; }
        public DbSet<teacherCourse> TeachersCourse { get; set; }

    }
}
