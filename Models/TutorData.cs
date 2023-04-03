using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;


namespace MvcMovie.Models;

public static class TutorData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
           
             
                if (context.Tutor.Any())
            {
                return;   // DB has been seeded
            }
             context.Tutor.AddRange(
                new Tutor
                {
                    Name = "John",
                    Surname = "Smith",
                    Salary = 4000
                    
                },
                new Tutor
                {
                    Name = "Sally",
                    Surname = "Hensen",
                    Salary = 900
                },
                new Tutor
                {
                    Name = "Sue",
                    Surname = "Roberts",
                    Salary = 2000
                },
                new Tutor
                {
                    Name = "Robert",
                    Surname = "Williams",
                    Salary = 8000
                }
            );
            context.SaveChanges();
        }//sa fie virgula de dupa salariu cea care nu e ok? acum vad
    }//si la restul obiectelor de tip tutor
}