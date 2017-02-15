using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Totosinho.Domain.Interfaces.Servicos
{
    public interface IServico<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        void AddAll(IEnumerable<TEntity> obj);
        void DeleteAll(IEnumerable<TEntity> obj);
        void Delete(TEntity obj);
        void Delete(int id);

        TEntity Get(int id);

        TEntity First();
        IQueryable<TEntity> Get();
        void Update(TEntity obj);

        void Commit();

        void AddOrUpdate(TEntity obj);
    }
}
