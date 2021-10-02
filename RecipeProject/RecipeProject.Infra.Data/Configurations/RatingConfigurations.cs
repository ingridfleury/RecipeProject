using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeProject.Domain.Model;

namespace RecipeProject.Infra.Data.Configurations
{
    class RatingConfigurations : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            //builder.HasOne(x => x.Recipe).WithMany(x => x.Ratings).OnDelete(DeleteBehavior.NoAction);
        }
    }

}
