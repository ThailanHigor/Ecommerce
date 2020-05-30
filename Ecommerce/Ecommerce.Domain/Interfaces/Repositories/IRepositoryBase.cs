using System.Collections.Generic;

namespace Ecommerce.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Remove(TEntity obj);
        void Update(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();

        void Dispose();

    }
}
