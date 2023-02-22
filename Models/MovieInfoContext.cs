using System;
using Microsoft.EntityFrameworkCore;

namespace Mission06_jazz3987.Models
{
	public class MovieInfoContext : DbContext
	{
		// Constructor
		public MovieInfoContext (DbContextOptions<MovieInfoContext> options) : base (options)
		{

		}

		public DbSet<MovieForm> MovieForms { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            // Seed Categories
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Anime"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Comedy/Drama"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Action/Adventure"
                }
                );

            //Seed database
            mb.Entity<MovieForm>().HasData(
				
				new MovieForm
				{
					MovieId = 1,
					CategoryID = 1,
					Title = "Kimi no na wa",
					Year = 2016,
					Director = "Makoto Shinkai",
					Rating = "PG-13",
					Edited = "",
					LentTo = "",
					Notes = ""
				},
                new MovieForm
                {
                    MovieId = 2,
                    CategoryID = 1,
                    Title = "Tenki no Ko",
                    Year = 2019,
                    Director = "Makoto Shinkai",
                    Rating = "PG-13",
                    Edited = "No",
                    LentTo = "",
                    Notes = ""
                },
                new MovieForm
                {
                    MovieId = 3,
                    CategoryID = 2,
                    Title = "Everything Everywhere All at Once",
                    Year = 2022,
                    Director = "Daniel Kwan",
                    Rating = "R",
                    Edited = "",
                    LentTo = "Jacob",
                    Notes = "Very trippy"
                }

            );
        }
    }
}

