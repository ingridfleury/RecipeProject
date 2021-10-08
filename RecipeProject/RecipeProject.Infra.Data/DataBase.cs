using Microsoft.EntityFrameworkCore;
using RecipeProject.Domain.Model;



namespace RecipeProject.Infra.Data
{
    public class DataBase : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Category { get; set; }

        public DataBase(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataBase).Assembly);
        }

    }
}
