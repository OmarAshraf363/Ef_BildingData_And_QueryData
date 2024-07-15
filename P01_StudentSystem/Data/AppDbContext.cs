using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-2MO8HKE\\OM;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
               .Property(s => s.Name)
               .HasMaxLength(100)
               .IsUnicode(true);

            modelBuilder.Entity<Student>()
                 .Property(s => s.PhoneNumber)
                 .HasMaxLength(10)
                 .IsUnicode(false)
                 .IsRequired(false);

            //modelBuilder.Entity<Student>()
            //     .Property(s => s.Birthday)
            //     .IsRequired(false);

            modelBuilder.Entity<Course>()
               .Property(c => c.Name)
               .HasMaxLength(80)
               .IsUnicode(true);

            modelBuilder.Entity<Course>()
                .Property(c => c.Description)
                .IsUnicode(true)
                .IsRequired(false);

            modelBuilder.Entity<Resource>()
               .Property(r => r.Name)
               .HasMaxLength(50)
               .IsUnicode(true);

            modelBuilder.Entity<Resource>()
               .Property(r => r.Url)
               .IsUnicode(false);

            modelBuilder.Entity<Homework>()
               .Property(h => h.Content)
               .IsUnicode(false);
            //composite Primary Key
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            //Seeding Data
            List<Student> students = new List<Student>()
            {
                new Student(){StudentId=1, Name="Omar",PhoneNumber="123456789",RegisteredOn=DateTime.Now},
                new Student(){ StudentId=2,Name="Fahed",PhoneNumber="124556789",RegisteredOn=DateTime.Now},
                new Student(){ StudentId=3,Name="Mostafa",PhoneNumber="123456319",RegisteredOn=DateTime.Now.AddDays(-5)},
                new Student(){ StudentId=4,Name="Ashraf",PhoneNumber="123913789",RegisteredOn=DateTime.Now.AddDays(-3)},
            };
            modelBuilder.Entity<Student>().HasData(students);


            modelBuilder.Entity<Course>().HasData(
              new Course { CourseId = 1, Name = "Mathematics", Description = "Basic Mathematics Course", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), Price = 1000 },
              new Course { CourseId = 2, Name = "Physics", Description = "Basic Physics Course", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), Price = 1200 },
              new Course { CourseId = 3, Name = "Chemistry", Description = "Basic Chemistry Course", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), Price = 1100 }
          );

            modelBuilder.Entity<StudentCourse>().HasData(
               new StudentCourse { StudentId = 1, CourseId = 1 },
               new StudentCourse { StudentId = 1, CourseId = 2 },
               new StudentCourse { StudentId = 2, CourseId = 2 },
               new StudentCourse { StudentId = 3, CourseId = 3 }
           );

            modelBuilder.Entity<Resource>().HasData(
               new Resource { ResourceId = 1, Name = "Math Book", Url = "http://mathbook.com", ResourceType = Resource.Types.Document,CourseId=1 },
               new Resource { ResourceId = 2, Name = "Physics Video", Url = "http://physicsvideo.com", ResourceType = Resource.Types.Video,CourseId=2 },
               new Resource { ResourceId = 3, Name = "Chemistry Presentation", Url = "http://chemistrypresentation.com", ResourceType = Resource.Types.Presentation,CourseId=3 }
           );

            modelBuilder.Entity<Homework>().HasData(
               new Homework { HomeworkId = 1, Content = "Math Homework Content", Contentype = Homework.Types.Pdf, SubmissionTime = DateTime.Now,StudentId=1, CourseId = 2 },
               new Homework { HomeworkId = 2, Content = "Physics Homework Content", Contentype = Homework.Types.Application, SubmissionTime = DateTime.Now, StudentId = 2, CourseId = 3 },
               new Homework { HomeworkId = 3, Content = "Chemistry Homework Content", Contentype = Homework.Types.Zip, SubmissionTime = DateTime.Now, StudentId = 3, CourseId = 1 }
           );
        }
    }
}
