using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMCV.Models
{
    public class Movie
    {
        
        public int Id { get; set; }
        
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public List<string> Actors { get; set; }
        public List<string> Directors { get; set; }
    }
}
