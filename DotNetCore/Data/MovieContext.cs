using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
           
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieQuality> MovieQualities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieQuality>().HasData(
                new MovieQuality
                {
                    Id = 1,
                    Quality = "HD"
                },
                new MovieQuality
                {
                    Id = 2,
                     Quality = "720p"
                },
                new MovieQuality
                {
                    Id = 3,
                    Quality = "1080p"
                },
                new MovieQuality
                {
                    Id = 4,
                    Quality = "4k"
                });
        }
    }
}
