using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeProject.Domain.Model;

namespace RecipeProject.Infra.Data.Configurations
{
    public class RecipeIngredientsConfiguration : IEntityTypeConfiguration<RecipeIngredients>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredients> builder)
        {
            builder.HasKey(ri => new { ri.RecipeId, ri.IngredientId });
        }
    }
}
