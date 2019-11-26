using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestantSystem.Repository.Persistance
{
    public class GenericRepositories<TEntity> : IGenericRepositories<TEntity> where TEntity : class
    {
        private readonly ContestantDB _Context;
        public GenericRepositories()
        {
            _Context = new ContestantDB();
        }

        public void Add(TEntity entity)
        {
            _Context.Set<TEntity>().Add(entity);
            _Context.SaveChanges();
        }

        public TEntity GetbyID(int Id)
        {
            return _Context.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> GetList()
        {
            return _Context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            _Context.Set<TEntity>().Remove(entity);
            _Context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            if (entity==null)
                throw new ArgumentNullException("Empty");

            _Context.SaveChanges();
        }
    }
}
