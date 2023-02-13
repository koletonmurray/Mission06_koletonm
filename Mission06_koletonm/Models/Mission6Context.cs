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

        public DbSet<AddMovieResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddMovieResponse>().HasData(
                new AddMovieResponse
                {
                    MoviesId = 1,
                    Category = "Action/Adventure",
                    Title = "Avengers: Endgame",
                    Year = 2019,
                    Director = "Anthony Russo",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Best movie!"
                },
                new AddMovieResponse
                {
                    MoviesId = 2,
                    Category = "Family/Comdey",
                    Title = "Emporer's New Groove",
                    Year = 2000,
                    Director = "Mark Dindal",
                    Rating = "G",
                    Edited = false,
                    LentTo = "",
                    Notes = "A Classic!"
                }, 
                new AddMovieResponse
                {
                    MoviesId = 3,
                    Category = "War/Drama",
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
