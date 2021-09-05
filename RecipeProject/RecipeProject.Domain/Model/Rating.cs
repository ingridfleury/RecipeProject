using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    public class Rating
    {

        public int RatingId { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public int RatingSacale { get; set; }
        public DateTime DateTime { get; set; }
        private Rating()
        {

        }
        public Rating(int userId, int recipeId, int ratingSacale, DateTime dateTime)
        {
            UserId = userId;
            RecipeId = recipeId;
            RatingSacale = ratingSacale;
            DateTime = dateTime;
        }


    }
}
