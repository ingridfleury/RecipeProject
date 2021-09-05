using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    public class User 
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        private User()
        {

        }      
        public User(string email, string password)
        {
            Email = email;
            Password = password;

        }

    }
}
