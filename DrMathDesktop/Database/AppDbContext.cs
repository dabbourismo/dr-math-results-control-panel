using DrMathDesktop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMathDesktop.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=localServer")
        {
            //Database.Log = e => Debug.WriteLine(e);
        }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Result> Results { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainer>().ToTable("Trainers");
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Result>().ToTable("Results");

        }
    }
}
