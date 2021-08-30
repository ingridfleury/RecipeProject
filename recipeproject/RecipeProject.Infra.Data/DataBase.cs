using Microsoft.EntityFrameworkCore;
using RecipeProject.Domain.Model;



namespace RecipeProject.Infra.Data
{
    public class DataBase : DbContext
    {
        public static DbSet<User> users;

    }
}
