using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    public class UserAdmin
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserAdmin(int id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
        }

    }
}
