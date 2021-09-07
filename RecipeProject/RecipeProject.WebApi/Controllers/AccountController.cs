using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeProject.Domain.Model;
using RecipeProject.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RecipeProject.WebApi.Controllers
{
    public class AccountController : BaseController
    {
        private readonly DataBase _context;
        public AccountController(DataBase context)
        {
            _context = context;

        }
        [HttpPost]
        public async Task<ActionResult<User>> Register(string email, string password)
        {
            var hmac = new HMACSHA512();
            var user = new User()
            {
                Email = email,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                PasswordSalt = hmac.Key
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;


        } 
    }
}
