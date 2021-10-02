using System;

namespace RecipeProject.Domain.Model
{
    public class Rating
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int? RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int RatingSacale { get; set; }
        public DateTime DateTime { get; set; }

        private Rating()
        {

        }

        public Rating(int ratingSacale, DateTime dateTime)
        {
            RatingSacale = ratingSacale;
            DateTime = dateTime;
        }
    }
}
