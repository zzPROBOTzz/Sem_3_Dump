using multi_tier_Exam.BAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_tier_Exam.BLL
{
    public class DirectorManager
    {
        private MovieLibraryDBEntities3 dbContext = new MovieLibraryDBEntities3();

        public List<Director> getAllDirectors()
        {
            return dbContext.Directors.ToList();
        }

        public void AddDirector(int id, string firstName, string lastName)
        {
            Director newDirector = new Director();
            newDirector.DirectorID = id;
            newDirector.FirstName = firstName;
            newDirector.LastName = lastName;

            dbContext.Directors.Add(newDirector);
            dbContext.SaveChanges();
        }

        public void RemoveDirector(int id)
        {
            List<Director> directors = dbContext.Directors.Where(Director => Director.DirectorID == id).ToList();

            foreach(Director director in directors)
            {
                dbContext.Directors.Remove(director);
            }
           
        }

        public void UpdateDirector(int id, string firstName, string lastName)
        {
            var updateDirector = dbContext.Directors.Find(id);
            updateDirector.FirstName = firstName;
            updateDirector.LastName = lastName;
        }
    }
}
