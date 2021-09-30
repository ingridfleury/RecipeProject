using System;
using System.Collections.Generic;

namespace RecipeProject.Domain.Model
{
    public class Recipe
    {
        // variáveis privadas > auto implemented prop > prop > ctor (do menor pro maior) > metodos publicos > metodos privados
        
        private string _Name;
        private string _Preparation;

        public int RecipeId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int DificultyId { get; set; }
        public Dificulty Dificulty { get; set; }

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
            Ingredients = new List<RecipeIngredients>();
        }

        public Recipe(string name, string preparationMethod) : this()
        {
            Name = name;
            PreparationMethod = preparationMethod;
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

            if (preparation.Length >= 1000)
            {
                throw new ArgumentException("The preparation can't has more then 1000 characters.");
            }

            return true;
        }

    }
}
