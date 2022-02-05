using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCTicket.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "El ultimo tour del mundo",
                        Artist = " bad bunny",
                        ReleaseDate = DateTime.Parse("2021-2-12"),
                        Genre = "Reguetton",
                        Price = 199M
                    },

                    new Movie
                    {
                        Title = " La hora de dormir  ",
                        Artist = " Adele ",
                        ReleaseDate = DateTime.Parse("2022-3-13"),
                        Genre = " Coutry",
                        Price = 1890M
                    },

                    new Movie
                    {
                        Title = " Little sky ",
                        Artist = " Billy joel ",
                        ReleaseDate = DateTime.Parse("2022-2-23"),
                        Genre = "Alternative",
                        Price = 2500M
                    },

                    new Movie
                    {
                        Title = " LATAM ",
                        Artist = " Residente ",
                        ReleaseDate = DateTime.Parse("2022-4-15"),
                        Genre = " Pop",
                        Price = 1300M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}