using CourseRegistrationApp.Models;
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
        public DbSet<Students> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Courses>().HasData(
                    new Courses { C_CourseId = 101, C_CourseNumber = 2400, C_CourseName = "Homeopathy", C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." },
                    new Courses { C_CourseId = 102, C_CourseNumber = 2410, C_CourseName = "Astrology", C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." },
                    new Courses { C_CourseId = 103, C_CourseNumber = 2420, C_CourseName = "Programming", C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." },
                    new Courses { C_CourseId = 104, C_CourseNumber = 2430, C_CourseName = "Mathematics", C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." }

                );
            modelBuilder.Entity<Students>().HasData(
                    new Students { S_Id = 3101, S_FirstName = "John", S_LastName = "Lenon", S_Email = "johnLenon@gmail.com", S_PhoneNumber = "123-456-67890", C_CourseId = 104 },
                    new Students { S_Id = 3102, S_FirstName = "Ringo", S_LastName = "Starr", S_Email = "ringoStarr@gmail.com", S_PhoneNumber = "987-233-7755", C_CourseId = 102 },
                    new Students { S_Id = 3103, S_FirstName = "Paul", S_LastName = "McCartney", S_Email = "paulmccartney@gmail.com", S_PhoneNumber = "321-654-4532", C_CourseId = 104 },
                    new Students { S_Id = 3104, S_FirstName = "Geordge", S_LastName = "Harrison", S_Email = "georgeharrison@gmail.com", S_PhoneNumber = "233-342-7754", C_CourseId = 102 },
                    new Students { S_Id = 3105, S_FirstName = "Steven", S_LastName = "Lenon", S_Email = "stevenLenon@gmail.com", S_PhoneNumber = "123-456-67890", C_CourseId = 103 },
                    new Students { S_Id = 3106, S_FirstName = "Roger", S_LastName = "Starr", S_Email = "rogerStarr@gmail.com", S_PhoneNumber = "987-233-7755", C_CourseId = 103 },
                    new Students { S_Id = 3107, S_FirstName = "Bob", S_LastName = "McCartney", S_Email = "bobmccartney@gmail.com", S_PhoneNumber = "321-654-4532", C_CourseId = 103 },
                    new Students { S_Id = 3108, S_FirstName = "Briant", S_LastName = "Harrison", S_Email = "briantharrison@gmail.com", S_PhoneNumber = "233-342-7754", C_CourseId = 103 }

                );
        }

    }
}
