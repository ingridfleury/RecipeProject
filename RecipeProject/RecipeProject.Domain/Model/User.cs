using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    public class User : Person
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int id, string email, string password, string firstName, string lastName)
        {
            Id = id;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
