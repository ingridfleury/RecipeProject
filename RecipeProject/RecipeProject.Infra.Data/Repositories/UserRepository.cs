using RecipeProject.Domain.Model;

namespace RecipeProject.Infra.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataBase context) : base(context)
        {
        }
    }
}
