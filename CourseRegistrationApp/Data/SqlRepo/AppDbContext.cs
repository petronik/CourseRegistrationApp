﻿using CourseRegistrationApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.SqlRepo
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options){ }

        public DbSet<Courses> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        
    }
}
