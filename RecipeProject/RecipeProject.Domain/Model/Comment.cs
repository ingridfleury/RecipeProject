using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    class Comment
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public DateTime DateTime { get; set; }
        public string CommentText { get; set; }

    }
}
