namespace RecipeProject.Application.Dto
{
    public class RecipeDto
    {
        public int RecipeId { get; set; }
        public int UserId { get; set; }
        public int DificultyId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string PreparationMethod { get; set; }


    }
}
