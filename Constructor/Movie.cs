using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Movie
    {
        public Movie()
        {

        }
        public Movie(int movieId,string movieName, string movieGenre)
        {
            MovieId= movieId;
            MovieGenre = movieGenre;
            MovieName = movieName;
        }
        
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
    }
}
