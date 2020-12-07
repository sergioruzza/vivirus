using System;
using GradesContext.Models;

using Microsoft.EntityFrameworkCore;

namespace GradesContext
{
    public class Grades : DbContext
    {
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TeacherType> TeacherType { get; set; }
        public DbSet<TeacherSubject> TeacherSubject { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<PeriodType> PeriodType { get; set; }
        public DbSet<Assignature> Assignature { get; set; }

        public Grades(DbContextOptions<Grades> options)
        :base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "../Database/Grades.db";
            optionsBuilder.UseSqlite($"Filename = {path}");
        }
    }
}
