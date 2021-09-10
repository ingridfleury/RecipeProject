using RecipeProject.Domain.Model;
using RecipeProject.Infra.Data;
using RecipeProject.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.ConsoleApp
{
    public class StartUp
    {
        public StartUp()
        {
        }

        public void Run(string[] args)
        {
            Console.WriteLine("1. User List");
            Console.WriteLine("2. User Creation");
            Console.WriteLine("3. User Update");
            Console.WriteLine("4. User Delete");
        }
    }

    public class UserConsole
    {
        private readonly IUserRepository userRepository;

        public UserConsole(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Start()
        {
            userRepository.Create(new User()
            {
                Email = "ingrid@gmail.com"
            });
        }

    }
}
