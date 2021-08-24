﻿// <auto-generated />
using System;
using CourseRegistrationApp.Data.SqlRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseRegistrationApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("CourseRegistrationApp.Models.Course", b =>
                {
                    b.Property<int>("C_CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("C_CourseDescrip")
                        .HasColumnType("longtext");

                    b.Property<string>("C_CourseName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("C_CourseNumber")
                        .HasColumnType("int");

                    b.HasKey("C_CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            C_CourseId = 101,
                            C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            C_CourseName = "Homeopathy",
                            C_CourseNumber = 2400
                        },
                        new
                        {
                            C_CourseId = 102,
                            C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            C_CourseName = "Astrology",
                            C_CourseNumber = 2410
                        },
                        new
                        {
                            C_CourseId = 103,
                            C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            C_CourseName = "Programming",
                            C_CourseNumber = 2420
                        },
                        new
                        {
                            C_CourseId = 104,
                            C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            C_CourseName = "Mathematics",
                            C_CourseNumber = 2430
                        });
                });

            modelBuilder.Entity("CourseRegistrationApp.Models.Instructor", b =>
                {
                    b.Property<int>("I_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("C_CourseId")
                        .HasColumnType("int");

                    b.Property<string>("I_Email")
                        .HasColumnType("longtext");

                    b.Property<string>("I_FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("I_LastName")
                        .HasColumnType("longtext");

                    b.HasKey("I_Id");

                    b.HasIndex("C_CourseId");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            I_Id = 2501,
                            C_CourseId = 101,
                            I_Email = "johndoe@gmail.com",
                            I_FirstName = "John",
                            I_LastName = "Doe"
                        },
                        new
                        {
                            I_Id = 2502,
                            C_CourseId = 104,
                            I_Email = "bellamandella@gmail.com",
                            I_FirstName = "Bella",
                            I_LastName = "Mandella"
                        },
                        new
                        {
                            I_Id = 2503,
                            C_CourseId = 102,
                            I_Email = "paulfisher@gmail.com",
                            I_FirstName = "Paul",
                            I_LastName = "Fisher"
                        },
                        new
                        {
                            I_Id = 2504,
                            C_CourseId = 103,
                            I_Email = "simonhil@gmail.com",
                            I_FirstName = "Simon",
                            I_LastName = "Hill"
                        });
                });

            modelBuilder.Entity("CourseRegistrationApp.Models.Student", b =>
                {
                    b.Property<int>("S_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("C_CourseId")
                        .HasColumnType("int");

                    b.Property<string>("S_Email")
                        .HasColumnType("longtext");

                    b.Property<string>("S_FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("S_LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("S_PhoneNumber")
                        .HasColumnType("longtext");

                    b.HasKey("S_Id");

                    b.HasIndex("C_CourseId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            S_Id = 3101,
                            C_CourseId = 104,
                            S_Email = "johnLenon@gmail.com",
                            S_FirstName = "John",
                            S_LastName = "Lenon",
                            S_PhoneNumber = "123-456-67890"
                        },
                        new
                        {
                            S_Id = 3102,
                            C_CourseId = 102,
                            S_Email = "ringoStarr@gmail.com",
                            S_FirstName = "Ringo",
                            S_LastName = "Starr",
                            S_PhoneNumber = "987-233-7755"
                        },
                        new
                        {
                            S_Id = 3103,
                            C_CourseId = 104,
                            S_Email = "paulmccartney@gmail.com",
                            S_FirstName = "Paul",
                            S_LastName = "McCartney",
                            S_PhoneNumber = "321-654-4532"
                        },
                        new
                        {
                            S_Id = 3104,
                            C_CourseId = 102,
                            S_Email = "georgeharrison@gmail.com",
                            S_FirstName = "Geordge",
                            S_LastName = "Harrison",
                            S_PhoneNumber = "233-342-7754"
                        },
                        new
                        {
                            S_Id = 3105,
                            C_CourseId = 103,
                            S_Email = "stevenLenon@gmail.com",
                            S_FirstName = "Steven",
                            S_LastName = "Lenon",
                            S_PhoneNumber = "123-456-67890"
                        },
                        new
                        {
                            S_Id = 3106,
                            C_CourseId = 103,
                            S_Email = "rogerStarr@gmail.com",
                            S_FirstName = "Roger",
                            S_LastName = "Starr",
                            S_PhoneNumber = "987-233-7755"
                        },
                        new
                        {
                            S_Id = 3107,
                            C_CourseId = 103,
                            S_Email = "bobmccartney@gmail.com",
                            S_FirstName = "Bob",
                            S_LastName = "McCartney",
                            S_PhoneNumber = "321-654-4532"
                        },
                        new
                        {
                            S_Id = 3108,
                            C_CourseId = 103,
                            S_Email = "briantharrison@gmail.com",
                            S_FirstName = "Briant",
                            S_LastName = "Harrison",
                            S_PhoneNumber = "233-342-7754"
                        });
                });

            modelBuilder.Entity("CourseRegistrationApp.Models.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("CourseRegistrationApp.Models.Instructor", b =>
                {
                    b.HasOne("CourseRegistrationApp.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("C_CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("CourseRegistrationApp.Models.Student", b =>
                {
                    b.HasOne("CourseRegistrationApp.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("C_CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("CourseRegistrationApp.Models.StudentCourse", b =>
                {
                    b.HasOne("CourseRegistrationApp.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseRegistrationApp.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
