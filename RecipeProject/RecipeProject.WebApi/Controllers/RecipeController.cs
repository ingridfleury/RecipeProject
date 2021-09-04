using Microsoft.AspNetCore.Mvc;
using RecipeProject.Domain.Model;
using RecipeProject.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeProject.WebApi.Controllers
{
    public class RecipeController : BaseController
    {
        private readonly DataBase _context;

        public RecipeController(DataBase context)
        {
            _context = context;

        }

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> GetAll()
        {
            return _context.Recipes.ToList();
        }
    }
}
