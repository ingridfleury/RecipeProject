using RecipeProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Infra.Data.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(DataBase context) : base(context)
        {
        }
    }
}
