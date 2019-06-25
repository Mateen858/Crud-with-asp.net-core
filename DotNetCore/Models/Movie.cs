using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public bool IsWatched { get; set; }
        public string CoverImageUrl { get; set; }
        public int QualityId { get; set; }
        [Display(Name ="Cover")]
        public string ImageUrl { get; set; }


    }
}
