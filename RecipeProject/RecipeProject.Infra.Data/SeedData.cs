using RecipeProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Infra.Data
{
    public class SeedData
    {
        private static readonly Random r = new Random();
        public static List<User> Seed(int userNumbers)
        {
            List<User> users = new List<User>();
            for (int i = 0; i < userNumbers; i++)
            {
                users.Add(CreateUser());
            }

        }

        private static User CreateUser(int id, string name, byte[] passwordHash)
        {
            id = id,   
            
        }
    }
}
