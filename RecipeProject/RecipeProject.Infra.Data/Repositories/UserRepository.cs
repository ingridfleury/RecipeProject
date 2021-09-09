using RecipeProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Infra.Data.Repositories
{
    class UserRepository : Repository<User>
    {
        public UserRepository(DataBase context) : base(context)
        {
        }
    }
}
