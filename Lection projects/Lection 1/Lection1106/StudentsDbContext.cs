using Lection1106.Models;
using Microsoft.EntityFrameworkCore;

namespace Lection1106
{
    internal class StudentsDbContext : DbContext
    {
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source = mssql; Initial Catalog = ispp2111; User ID = ispp2111; Password = 2111; Trust Server Certificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
                new Group { Id = 1, Name = "ИСПП-21" },
                new Group { Id = 2, Name = "ИСПП-35" }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId=1, GroupId = 1, Name = "Клюшанов"},
                new Student { StudentId = 2, GroupId = 2, Name = "Unknown", Age = 17}
                );
        }
    }
}
