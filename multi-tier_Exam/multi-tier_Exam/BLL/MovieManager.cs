using multi_tier_Exam.BAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_tier_Exam.BLL
{
    public class MovieManager
    {
        private MovieLibraryDBEntities3 dbContext = new MovieLibraryDBEntities3();

        public List<Movy> getAllMovies()
        {
            return dbContext.Movies.ToList();
        }

        public void AddMovies(int id, string title, string genre, string releaseYear, string duration) 
        {
            Movy newMovie = new Movy();
            newMovie.MovieID = id;
            newMovie.Title = title;
            newMovie.Genre = genre;
            newMovie.ReleaseYear = releaseYear;
            newMovie.Duration_min_ = duration;

            dbContext.Movies.Add(newMovie);
            dbContext.SaveChanges();
           
        }

        public void RemoveMovies(int id)
        {
            List<Movy> movies = dbContext.Movies.Where(movie => movie.MovieID == id).ToList();

            foreach (Movy movie in movies)
            {
                dbContext.Movies.Remove(movie);
            }
        }

        public void UpdateMovie(int id, string title, string genre, string releaseYear, string duration)
        {
            var updateMovie = dbContext.Movies.Find(id);
            updateMovie.Title = title;
            updateMovie.Duration_min_ = duration;
            updateMovie.ReleaseYear = releaseYear;
            updateMovie.Genre = genre;
            dbContext.SaveChanges();
        }


    }
}
