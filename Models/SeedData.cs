using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Check if any movies already exist
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Kabaddi Kabaddi",
                        ReleaseDate = DateTime.Parse("2015-11-27"),
                        Genre = "Romantic Comedy",
                        Rating = "PG",
                        Price = 5.99M
                    },
                    new Movie
                    {
                        Title = "Loot",
                        ReleaseDate = DateTime.Parse("2012-01-13"),
                        Genre = "Crime",
                        Rating = "PG-13",
                        Price = 6.99M
                    },
                    new Movie
                    {
                        Title = "Pashupati Prasad",
                        ReleaseDate = DateTime.Parse("2016-01-29"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 4.99M
                    },
                    new Movie
                    {
                        Title = "Kagbeni",
                        ReleaseDate = DateTime.Parse("2008-01-11"),
                        Genre = "Horror",
                        Rating = "PG",
                        Price = 3.99M
                    },
                    new Movie
                    {
                        Title = "Chhakka Panja",
                        ReleaseDate = DateTime.Parse("2016-09-09"),
                        Genre = "Comedy",
                        Rating = "U",
                        Price = 6.49M
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
