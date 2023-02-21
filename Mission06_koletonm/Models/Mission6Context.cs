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
                new MovieCategory { CategoryId = 1, CategoryName = "Action/Adventure"},
                new MovieCategory { CategoryId = 2, CategoryName = "Comedy" },
                new MovieCategory { CategoryId = 3, CategoryName = "Drama" },
                new MovieCategory { CategoryId = 4, CategoryName = "Family" },
                new MovieCategory { CategoryId = 5, CategoryName = "Horror" },
                new MovieCategory { CategoryId = 6, CategoryName = "Musical" },
                new MovieCategory { CategoryId = 7, CategoryName = "Mystery/Thriller" },
                new MovieCategory { CategoryId = 8, CategoryName = "Romance" },
                new MovieCategory { CategoryId = 9, CategoryName = "Science Fiction" },
                new MovieCategory { CategoryId = 10, CategoryName = "Sports" },
                new MovieCategory { CategoryId = 11, CategoryName = "War" }
            );

            mb.Entity<AddMovie>().HasData(
                new AddMovie
                {
                    MovieId = 1,
                    CategoryId = 1,
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
                    CategoryId = 2,
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
                    CategoryId = 4,
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
