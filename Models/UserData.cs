using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class UserData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }
            context.User.AddRange(
                new User
                {
                    Name = "Anne",
                    Surname = "Lorence",
                    MonthlyFee = 10
                },
                new User
                {
                    Name = "Smith",
                    Surname = "McDonald",
                    MonthlyFee = 80
                },
                new User
                {
                    Name = "Joshua",
                    Surname = "Sanders",
                    MonthlyFee = 100
                },
           
                 new User
                 {
                     Name = "Mary",
                     Surname = "Anne",
                     MonthlyFee = 80
                 }
                
            );
            context.SaveChanges();
        }
    }
}