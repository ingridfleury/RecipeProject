using System.Collections.Generic;

namespace RecipeProject.Infra.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity obj);
        TEntity Delete(TEntity obj);
        IEnumerable<TEntity> Get();
        TEntity GetById(int id);
        TEntity Update(TEntity obj);
    }
}