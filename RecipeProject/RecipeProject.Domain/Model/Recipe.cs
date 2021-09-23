using System;
using System.Collections.Generic;

namespace RecipeProject.Domain.Model
{
    public class Recipe
    {
        private string _Name;

        private string _Preparation;

        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int DificultyId { get; set; }
        public int RecipeId { get; set; }
        public string Name
        {
            get
            {
                return _Name;

            }
            set
            {
                if (ValidateName(value))
                {
                    _Name = value;
                }

            }
        }
        public string PreparationMethod
        {
            get
            {
                return _Preparation;
            }
            set
            {
                if (ValidatePreparation(value))
                {
                    _Preparation = value;
                }
            }
        }
        public IEnumerable<RecipeIngredients> Ingredients { get; set; }
        public Recipe()
        {

        }
        public Recipe(string name, string preparationMethod)
        {

            Name = name;
            PreparationMethod = preparationMethod;
            Ingredients = new List<RecipeIngredients>();

        }

        private bool ValidateName(string name)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name can't be empty or null");
            }

            if (name.Length <= 2)
            {
                throw new ArgumentException("name can't be less then 2");
            }

            if (name.Length >= 30)
            {
                throw new ArgumentException("name can't be more then 30");

            }

            return true;
        }

        private bool ValidatePreparation(string preparation)
        {
            if (string.IsNullOrEmpty(preparation))
            {
                throw new ArgumentNullException("Preparation can't be empty or null");
            }

            if (preparation.Length >= 500)
            {
                throw new ArgumentException("The preparation can't has more then 500 characters.");
            }

            return true;
        }

    }
}
