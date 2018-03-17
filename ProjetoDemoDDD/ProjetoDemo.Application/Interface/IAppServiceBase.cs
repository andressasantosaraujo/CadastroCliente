using System.Collections.Generic;

namespace ProjetoDemo.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Remove(TEntity obj);

        void Dispose();

        void Update(TEntity obj);
    }
}
