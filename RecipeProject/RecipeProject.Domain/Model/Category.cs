namespace RecipeProject.Domain.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public Category()
        {
        }

        public Category(string name)
        {
            Name = name;

        }

    }
}
