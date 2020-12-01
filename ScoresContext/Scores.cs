using System;
using Microsoft.EntityFrameworkCore;

//Clase contexo
//Modelos

namespace ScoresContext
{
    public class Scores : DbContext
    {
        //All database sets
        


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
