﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    public class Recipes
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int DificultyId { get; set; }
        public string Name { get; set; }
        public string PreparationMethod { get; set; }
        public List<IngredientsRecipe> Ingredients { get; set; }
        public Recipes(int id, int userId, int categoryId, int dificultyId, string name, string preparationMethod)
        {
            Id = id;
            UserId = userId;
            CategoryId = categoryId;
            DificultyId = dificultyId;
            Name = name;
            PreparationMethod = preparationMethod;
            Ingredients = new List<IngredientsRecipe>();

        }

    }
}
