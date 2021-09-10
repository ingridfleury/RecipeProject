using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeProject.Domain.Model;
using RecipeProject.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeProject.WebApi.Controllers
{
    [Authorize]
    public class RecipeController : BaseController
    {
        private readonly DataBase _context;

        public RecipeController(DataBase context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<IEnumerable<Recipe>> GetAll()
        {
            return await _context.Recipes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Recipe> GetById(int id)
        {
            return await _context.Recipes.FindAsync(id);
        }

        [HttpPost]
        public async Task<Recipe> Add(Recipe recipe)
        {
            await _context.Recipes.AddAsync(recipe);
            await _context.SaveChangesAsync();
            return recipe;
        }
    }
}
