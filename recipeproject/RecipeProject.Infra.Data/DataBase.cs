using Microsoft.EntityFrameworkCore;

namespace RecipeProject.Infra.Data
{
    public class DataBase : DbContext
    {
        public static DbSet<User> users;

    }
}
