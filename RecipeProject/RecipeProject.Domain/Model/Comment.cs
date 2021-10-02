using System;

namespace RecipeProject.Domain.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipes { get; set; }
        public DateTime DateTime { get; set; }
        public string CommentText { get; set; }
        private Comment()
        {

        }

        public Comment(DateTime dateTime, string commentText)
        {
            DateTime = dateTime;
            CommentText = commentText;
        }

    }
}
