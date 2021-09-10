using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Application.Contracts
{
    public interface IService<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Add(TEntity obj);
        TEntity Update(TEntity obj);
        TEntity Delete(TEntity obj);
    }
}
