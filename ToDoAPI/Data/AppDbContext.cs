using Microsoft.EntityFrameworkCore;
using ToDoAPI.Models;
namespace ToDoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<TodoItem>()
                .Property(t => t.Content).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
