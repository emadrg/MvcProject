﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Course> Course { get; set; } = default!;

        public DbSet<MvcMovie.Models.Tutor> Tutor { get; set; } = default!;

        public DbSet<MvcMovie.Models.User> User { get; set; } = default!;

        public DbSet<MvcMovie.Models.Book> Book { get; set; } = default!;
    }
}
