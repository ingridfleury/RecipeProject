using RecipeProject.Domain.Model.Enums;

namespace RecipeProject.Domain.Model
{
    public class Dificulty
    {

        public int DificultyId { get; set; }
        public DificultyOption DificultyDefinition { get; set; }
        private Dificulty()
        {

        }

        public Dificulty(DificultyOption dificultyDefinition)
        {
            DificultyDefinition = dificultyDefinition;
        }

    }
}
