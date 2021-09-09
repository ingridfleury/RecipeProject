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
        private readonly DataBase context;
        public StartUp()
        {
            this.context = context;
        }

        public void Run(string[] args)
        {

        }
    }

    public class UserConsole
    {
        private readonly IUserRepository userRepository;

        public UserConsole(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }


    }
}
