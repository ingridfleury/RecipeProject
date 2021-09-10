namespace RecipeProject.Domain.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        private Category() 
        {
        }

        public Category(string name)
        {
            Name = name;

        }

   }
}
