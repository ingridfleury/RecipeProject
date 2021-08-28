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
        public Rating(int ratingId, int userId, int recipeId, int ratingSacale, DateTime dateTime)
        {
            RatingId = ratingId;
            UserId = userId;
            RecipeId = recipeId;
            RatingSacale = ratingSacale;
            DateTime = dateTime;
        }


    }
}
