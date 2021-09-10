using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeProject.Domain.Model;
using RecipeProject.Infra.Data;
using RecipeProject.Infra.Data.Dtos;
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
        [HttpPost("registerquery")]
        public async Task<ActionResult<User>> Register(string name, string email, string password)
        {
            var hmac = new HMACSHA512();
            var user = new User()
            {
                Name = name,
                Email = email,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                PasswordSalt = hmac.Key
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;


        }
       
        [HttpPost("register")]
        [AllowAnonymous]

        public async Task<ActionResult<RegisteredUserDto>> Register(RegisteredUserDto registeredUserDto)
        {
            if (await UserAlreadyExists(registeredUserDto.Email))
            {
                return BadRequest("Email must be unique");
            }

            var hmac = new HMACSHA512();
            var user = new User()
            {
                Email = registeredUserDto.Email.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registeredUserDto.Password)),
                PasswordSalt = hmac.Key
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return new RegisteredUserDto()
            {
                Id = user.Id,
                Email = user.Email
            };
        }
        
        [HttpPost("login")]
        [AllowAnonymous]

        public async Task<ActionResult<RegisteredUserDto>> Login(LoginDto loginDto)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Email == loginDto.Email);

            if (user == null)
            {
                return Unauthorized("Invalid credentials");
            }

            var hmac = new HMACSHA512(user.PasswordSalt);
            var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

            for (int i = 0; i < passwordHash.Length; i++)
            {
                if(passwordHash[0] == user.PasswordHash[0])
                {
                    return Unauthorized("Invalid credentials");
                }

            }
            return new RegisteredUserDto()
            {
                Id = user.Id,
                Email = user.Email,

            };


        }
        private async Task<bool> UserAlreadyExists(string email)
        {
            return await _context.Users.AnyAsync(x => x.Email.ToLower() == email.ToLower());

        }

    }
}
