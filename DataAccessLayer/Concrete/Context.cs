using DataAccessLayer.Repository;
using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext //IdentityDbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = SABRI; database = MyOBS ; integrated security = True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LessonStudent>()
                .HasKey(ls => new { ls.StudentID, ls.LessonID });

            modelBuilder.Entity<LessonStudent>()
                .HasOne(ky => ky.Lesson)
                .WithMany(s => s.Students);
            
            modelBuilder.Entity<LessonStudent>()
                .HasOne(ky => ky.Student)
                .WithMany(s => s.Lessons);

           // base.OnModelCreating(modelBuilder);

        }

        


        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<LessonStudent> lessonStudents { get; set; }
        public DbSet<TeacherNotification> TeacherNotifications { get; set; }
    }
}
