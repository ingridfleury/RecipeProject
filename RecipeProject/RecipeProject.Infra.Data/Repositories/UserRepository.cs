﻿using RecipeProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Infra.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataBase context) : base(context)
        {
        }
    }
}