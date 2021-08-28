using System;
using System.Collections.Generic;
using System.Text;
using RecipeProject.Domain.Model.Enums;

namespace RecipeProject.Domain.Model
{
    public class Dificulty
    {

        public int DificultyId { get; set; }
        public DificultyOption DificultyDefinition { get; set; }

        public Dificulty(int dificultyId, DificultyOption dificultyDefinition)
        {
            DificultyId = dificultyId;
            DificultyDefinition = dificultyDefinition;
        }

    }
}
