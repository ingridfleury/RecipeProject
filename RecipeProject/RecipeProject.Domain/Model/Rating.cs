using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    class Rating
    {
        public int RatingId { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public int RatingSacale { get; set; }
        public DateTime DateTime { get; set; }


    }
}
