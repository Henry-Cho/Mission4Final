using System;
using Microsoft.EntityFrameworkCore;

namespace IS413Mission4.Models
{
    public class MovieContext : DbContext
    {
        // constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {

        }

        public DbSet<ApplicationResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
                    Title = "Harry Potter and the Chamber of Secrets",
                    Year = "2002",
                    Director = "Chris Columbus",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Logan Kim",
                    Note = "For FHE"
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    Category = "Action/Adventure",
                    Title = "Iron Man",
                    Year = "2008",
                    Director = "Jon Favreau",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Wayne Park",
                    Note = "For his dating"
                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    Category = "Drama",
                    Title = "About Time",
                    Year = "2013",
                    Director = "Richard Curtis",
                    Rating = "R",
                    Edited = true,
                    LentTo = "Yes",
                    Note = "For fun"
                }
            );
        }
    }
}
