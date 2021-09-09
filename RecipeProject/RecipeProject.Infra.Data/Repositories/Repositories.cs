using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeProject.Infra.Data.Repositories
{
    public class Repository<TEntity> where TEntity : class
    {
        protected readonly DataBase context;

        protected DbSet<TEntity> DbSet;

        public Repository(DataBase context)
        {
            this.context = context;
            DbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get()
        {
            return DbSet.ToList();
        }
        public TEntity Create(TEntity obj)
        {
            DbSet.Add(obj);
            context.SaveChanges();
            return obj;
        }

        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public TEntity Update(TEntity obj)
        {
            DbSet.Update(obj);
            context.SaveChanges();
            return obj;
        }
        public TEntity Delete(TEntity obj)
        {
            DbSet.Remove(obj);
            context.SaveChanges();
            return obj;
        }
    }
}
