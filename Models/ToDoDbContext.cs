using Microsoft.Data.Entity;

namespace ToDoRelationships.Models
{
    public class ToDoDbContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ToDoRelationships;integrated security=True;");
        }
    }
}
