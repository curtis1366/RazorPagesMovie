using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "game option #1",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "horror",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "game option #2 ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "simulator",
                        Price = 8.99M,
                        Rating = "M"
                    },

                    new Movie
                    {
                        Title = "game option #3",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "RPG",
                        Price = 9.99M,
                        Rating = "M"
                    },

                    new Movie
                    {
                        Title = "game option #4",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "MMO",
                        Price = 3.99M,
                        Rating = "M"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
