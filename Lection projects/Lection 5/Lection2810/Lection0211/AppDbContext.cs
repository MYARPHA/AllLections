using Microsoft.EntityFrameworkCore;

namespace Lection0211
{
    public class AppDbContext : DbContext
    {
        // В классе контекста БД указываются наборы данных
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // В нём указываются настройки подключения к БД 
            => optionsBuilder.UseSqlServer("Data Source=mssql;Initial Catalog=ispp2112;User ID=ispp2112;Password=2112;Trust Server Certificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            modelBuilder.Entity<Group>()
        }
    }
     
}