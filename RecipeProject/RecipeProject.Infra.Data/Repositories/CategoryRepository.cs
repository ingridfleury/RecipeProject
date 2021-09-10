using RecipeProject.Domain.Model;

namespace RecipeProject.Infra.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DataBase context) : base(context)
        {
        }
    }
}
