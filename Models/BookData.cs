using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class BookData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }
            context.Book.AddRange(
                new Book
                {
                    Title = "Programming for beginners",
                    ReleaseDate = DateTime.Parse("1999-4-4"),
                    Topic = "IT",
                    Price = 15
                },
                new Book
                {
                    Title = "How to cook like a pro",
                    ReleaseDate = DateTime.Parse("2012-12-24"),
                    Topic = "Cooking",
                    Price = 20
                },
                new Book
                {
                    Title = "Why money makes the world go round",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Topic = "Business",
                    Price = 25
                },
                new Book
                {
                    Title = "Stard coding with Ben",
                    ReleaseDate = DateTime.Parse("2022-9-18"),
                    Topic = "IT",
                    Price = 25
                },
                new Book
                {
                    Title = "Learn coding in quarantine",
                    ReleaseDate = DateTime.Parse("2020-5-15"),
                    Topic = "IT",
                    Price = 0
                },
                new Book
                {
                    Title = "A begginer's guide to vegan cooking",
                    ReleaseDate = DateTime.Parse("2021-6-1"),
                    Topic = "Cooking",
                    Price = 15
                }
            );
            context.SaveChanges();
        }
    }
}