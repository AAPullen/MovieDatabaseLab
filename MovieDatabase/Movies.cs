using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Movie
    {
        public string Title;
        public string Category;
        public int Runtime;
        public int Year;

        public static Movie CreateMovie(string title, string category, int runtime, int year)
        {
            Movie userMovie = new Movie();

            userMovie.Title = title;
            userMovie.Category = category;
            userMovie.Runtime = runtime;
            userMovie.Year = year;

            return userMovie;
        }
    }
}
