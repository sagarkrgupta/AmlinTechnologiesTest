using System.Collections.Generic;

namespace ContestantSystem.Repository.Persistance
{
    public interface IGenericRepositories<TEntity> where TEntity : class
    {
        TEntity GetbyID(int Id);
        IEnumerable<TEntity> GetList();

        void Add(TEntity entity);
        void Update(TEntity entity);

        void Remove(TEntity entity);



    }
}