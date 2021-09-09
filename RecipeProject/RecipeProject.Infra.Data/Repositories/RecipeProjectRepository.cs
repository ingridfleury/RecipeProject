using RecipeProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeProject.Infra.Data.Repositories
{
    public class RecipeProjectRepository : Repository<Recipe>
    {
        private readonly DataBase context;
        public RecipeProjectRepository(DataBase context) : base(context)
        {
            
        }

    }
}
