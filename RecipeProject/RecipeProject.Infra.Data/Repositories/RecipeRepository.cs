using RecipeProject.Domain.Model;

namespace RecipeProject.Infra.Data.Repositories
{
    public class RecipeRepository : Repository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(DataBase context) : base(context)
        {

        }

    }
}
