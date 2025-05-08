using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .HasKey(t => t.Id); 

            modelBuilder.Entity<Todo>()
                .Property(t => t.Id)
                .ValueGeneratedOnAdd(); 
        }
    }
}