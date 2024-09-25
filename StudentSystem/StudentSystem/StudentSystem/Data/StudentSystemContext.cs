using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    internal class StudentSystemContext:DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Resource>resources  { get; set; }
        public DbSet<Homework>homeworks  { get; set; }
        public DbSet<StudentCourse>studentCourses  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
                .Property(q => q.Name)
                .HasColumnType("varchar(100)")
                .IsUnicode(true);
            modelBuilder.Entity<Student>()
                .Property(w => w.PhoneNumber)
                .HasColumnType("varchar(10)")
                .HasDefaultValue(false)
                .IsUnicode(false);
            modelBuilder.Entity<Course>()
                .Property(e => e.Name)
                .HasColumnType("varchar(80)")
                .IsUnicode(true);
            modelBuilder.Entity<Course>()
                .Property(t => t.Description)
                .IsUnicode(true);
            modelBuilder.Entity<Resource>()
                .Property(r => r.Name)
                .HasColumnType("varchar(50)")
                .IsUnicode(true);
            modelBuilder.Entity<Resource>()
                .Property(s=>s.Url)
                .IsUnicode (true);
            modelBuilder.Entity<Resource>()
                .Property(r => r.ResourceType)
                .HasConversion<string>();
            modelBuilder.Entity<Homework>()
                .Property(s => s.Content)
                .IsUnicode(false);
            //modelBuilder.Entity<StudentCourse>()
            //    .HasKey(c=>c.StudentId);
            //modelBuilder.Entity<StudentCourse>()
            //     .HasKey(x => x.CourseId);


        }
    }
}
