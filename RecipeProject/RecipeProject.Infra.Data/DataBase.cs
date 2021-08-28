using RecipeProject.
using Microsoft.EntityFrameworkCore;
using System;

namespace RecipeProject.Infra.Data
{
    public class DataBase : DbContext
    {
        public static DbSet<User> users;

    }
}
