using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
    class City 
    { 
        public string Name { get; set; }

        public string Country { get; set; }
    }

    class Country
    {
        public string Name { get; set; }
        public string code { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>
            {
                new City { Name = "Montreal", Country = "Canada"},
                new City { Name = "Toronto", Country = "Canada"},
                new City { Name = "NYC", Country = "US"},
                new City { Name = "Chicago", Country = "US"},
                new City { Name = "Las-Vegas", Country = "US"}

            };



            List<Country> countries = new List<Country>
            {
                new Country { Name = "US", code = "001"},
                new Country { Name = "Canada", code = "002"}
            };


            //Get all cities
            var getAllCities = cities.Select(e => new { e.Name, e.Country });
            Console.WriteLine("--------------------------------------Getting All cities...-------------------------------------");
            foreach (var city in getAllCities) {

                Console.WriteLine($"{city.Name} - {city.Country}");
            }

            //Get city when the country is US
            var cityOfUS = from city in cities where city.Country == "US" select city.Name;
            Console.WriteLine("-------------------------------------Cities from US..-------------------------------------------");
            foreach (var city in cityOfUS) { 

                Console.WriteLine($"{city}");
            }

            //Getting the list of City
            var cityList = cities.Select(c => new {c.Name });
            Console.WriteLine("-------------------------------------All cities..----------------------------------------------");
            foreach (var city in cityList)
            {
                Console.WriteLine($"{city.Name}");
            }

        }
    }
}
