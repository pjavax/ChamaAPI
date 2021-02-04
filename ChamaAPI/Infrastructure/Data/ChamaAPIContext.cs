using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class ChamaAPIContext : DbContext
    {
        public ChamaAPIContext(DbContextOptions options) : base(options) { }

        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => new { e.IdStudent });
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => new { e.IdCourse });
            });
        }
    }
}
