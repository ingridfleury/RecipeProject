using RecipeProject.Domain.Model;

namespace RecipeProject.Application.Contracts
{
    public interface ITokenService
    {
        string CreateToken(User user);

    }
}
