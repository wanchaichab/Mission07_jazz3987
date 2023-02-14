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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<MovieForm>().HasData(
				//Seed database
				new MovieForm
				{
					MovieId = 1,
					Category = "Anime",
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
                    Category = "Anime",
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
                    Category = "Comedy/Drama",
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

