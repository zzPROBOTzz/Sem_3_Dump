using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cineplexx
{
    
        public class Movie
        {
            //private attributes
            private int moviecode;
            private string title;
            private string actorname;

            
            private EnumType movieType;

            private EnumLanguage movieLanguage;



        private EnumLanguage language;


        Console.writeline("Sanket Bhut");
            //public properties
            public int MovieCode
            {
                get { return this.moviecode; }
                set { this.moviecode = value; }
            }
            public string Titile
            {
                get { return this.title; }
                set { this.title = value; }
            }
            public string ActorName
            {
                get { return this.actorname; }
                set { this.actorname = value; }
            }

            

            public EnumType MovieType
            {
                get { return this.movieType; }
                set { this.movieType = value; }
            }

            public EnumLanguage MoviesLanguage
        {
                get { return this.movieLanguage; }
                set { this.movieLanguage = value; }
            }





        public EnumLanguage languages
            {
                get { return this.language; }
                set { this.language = value; }

            }

            

            public Movie()
            {
                this.language = EnumLanguage.Undefined;
            }

            public Movie(int moviecode, string title, string actorname)
            {
                this.moviecode = moviecode;
                this.title = title;
                this.actorname = actorname;

                
            }

            

            public Movie(int moviecode, string title, string actorname, EnumLanguage languages,Time movieTime)
            {
                this.moviecode = moviecode;
                this.title = title;
                this.actorname = actorname;
                
                this.languages = languages;
            }

            
            public override String ToString()
            {
                String state;
                state = this.moviecode + " - " + this.title + " - " + this.actorname + " = ";
                return state;
            }
        
        }
    
       
    
}
