using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Infra.Data.Dtos
{
    public class RegisteredUserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
