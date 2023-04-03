using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class CourseData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Course.Any())
            {
                return;   // DB has been seeded
            }
            context.Course.AddRange(
                new Course
                {
                    Title = "Cooking with Martha",
                    ReleaseDate = DateTime.Parse("1999-12-12"),
                    Topic = "Cooking",
                    Price = 80,
                    Rating = 5
                },
                new Course
                {
                    Title = "OOP for dummies ",
                    ReleaseDate = DateTime.Parse("2012-04-15"),
                    Topic = "IT",
                    Price = 40,
                    Rating = 5    
                },
                new Course
                {
                    Title = "Inflation 101",
                    ReleaseDate = DateTime.Parse("1999-2-25"),
                    Topic = "Business",
                    Price = 13,
                    Rating = 2
                },
                new Course
                {
                    Title = "French cooking",
                    ReleaseDate = DateTime.Parse("2002-07-14"),
                    Topic = "Cooking",
                    Price = 20,
                    Rating = 5
                }
            );
            context.SaveChanges();
        }
    }
}