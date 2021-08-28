﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    public class Comment
    {

        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public DateTime DateTime { get; set; }
        public string CommentText { get; set; }

        public Comment(int commentId, int userId, int recipeId, DateTime dateTime, string commentText)
        {
            CommentId = commentId;
            UserId = userId;
            RecipeId = recipeId;
            DateTime = dateTime;
            CommentText = commentText;
        }

    }
}
