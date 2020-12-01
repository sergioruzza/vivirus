using System;
using ScoresContext.Models;

using Microsoft.EntityFrameworkCore;

//Clase contexo
//Modelos

namespace ScoresContext
{
    public class Scores : DbContext
    {
        //All database sets
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TeacherType> TeacherType { get; set; }
        public DbSet<TeacherSubject> TeacherSubject { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<GroupAtSchool> GroupAtSchool { get; set; }
        public DbSet<PeriodType> PeriodType { get; set; }
        public DbSet<Assignature> Assignature { get; set; }

        // Constructor
        public Scores(DbContextOptions<Scores> options)
        :base(options){}

        //Config global restrictions
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //Create connection with database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "../Database/Scores.db";
            optionsBuilder.UseSqlite($"Filename = {path}");
        }
    }
}
