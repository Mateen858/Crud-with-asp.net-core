using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Models
{
    public class MovieViewModel
    {
        public Movie movie { get; set; }
        public List<MovieQuality> movieQualities { get; set; }
    }
}
