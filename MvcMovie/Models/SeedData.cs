using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models {
    public static class SeedData {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>())) {
                // Look for any movies.
                if (context.Movie.Any()) {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-4-12"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 2.99M
                    },

                    new Movie {
                        Title = "The Other Side of Heaven 2: Fire of Faith",
                        ReleaseDate = DateTime.Parse("2019-6-28"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 3.99M
                    },

                    new Movie {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 4.99M
                    },

                    new Movie {
                        Title = "The Fighting Preacher",
                        ReleaseDate = DateTime.Parse("2019-7-24"),
                        Genre = "History",
                        Rating = "PG",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}