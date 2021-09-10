using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RecipeProject.Infra.Data.Dtos
{
    public class RegisteredUserDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string JwtToken { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
