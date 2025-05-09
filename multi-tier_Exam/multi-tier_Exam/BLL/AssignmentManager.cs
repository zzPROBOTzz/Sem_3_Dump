using multi_tier_Exam.BAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_tier_Exam.BLL
{
    public class AssignmentManager
    {
        private MovieLibraryDBEntities3 dbContext = new MovieLibraryDBEntities3();

        public List<MovieDirector> getAll()
        {
            return dbContext.MovieDirectors.ToList();
        }

        public void addAssign(int assignID, int movieID, int directorID)
        {
            MovieDirector newAssign = new MovieDirector();
            newAssign.AssignID = assignID;
            newAssign.MovieID = movieID;    
            newAssign.DirectorID = directorID;

            dbContext.MovieDirectors.Add(newAssign);
            dbContext.SaveChanges();
        }
    }
}
