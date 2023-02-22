using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_koletonm.Models
{
    public class Mission6Context : DbContext
    {
        // Contstructor
        public Mission6Context(DbContextOptions<Mission6Context> options) : base (options)
        {

        }

        public DbSet<AddMovie> Movies { get; set; }
        public DbSet<MovieCategory > MovieCategories { get; set; }
        // Seeding the data

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieCategory>().HasData(
                new MovieCategory { MovieCategoryId = 1, MovieCategoryName = "Action/Adventure"},
                new MovieCategory { MovieCategoryId = 2, MovieCategoryName = "Comedy" },
                new MovieCategory { MovieCategoryId = 3, MovieCategoryName = "Drama" },
                new MovieCategory { MovieCategoryId = 4, MovieCategoryName = "Family" },
                new MovieCategory { MovieCategoryId = 5, MovieCategoryName = "Horror" },
                new MovieCategory { MovieCategoryId = 6, MovieCategoryName = "Musical" },
                new MovieCategory { MovieCategoryId = 7, MovieCategoryName = "Mystery/Thriller" },
                new MovieCategory { MovieCategoryId = 8, MovieCategoryName = "Romance" },
                new MovieCategory { MovieCategoryId = 9, MovieCategoryName = "Science Fiction" },
                new MovieCategory { MovieCategoryId = 10, MovieCategoryName = "Sports" },
                new MovieCategory { MovieCategoryId = 11, MovieCategoryName = "War" }
            );

            mb.Entity<AddMovie>().HasData(
                new AddMovie
                {
                    MovieId = 1,
                    MovieCategoryId = 1,
                    Title = "Avengers: Endgame",
                    Year = 2019,
                    Director = "Anthony Russo",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Best movie!"
                },
                new AddMovie
                {
                    MovieId = 2,
                    MovieCategoryId = 2,
                    Title = "Emporer's New Groove",
                    Year = 2000,
                    Director = "Mark Dindal",
                    Rating = "G",
                    Edited = false,
                    LentTo = "",
                    Notes = "A Classic!"
                }, 
                new AddMovie
                {
                    MovieId = 3,
                    MovieCategoryId = 4,
                    Title = "The Zookeeper's Wife",
                    Year = 2017,
                    Director = "Niki Caro",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Tragic, but so moving"
                }
            );
        }
    }
}
