using System.Collections.Generic;
using System.Linq;
using Totosinho.Domain.Entidades;

namespace Totosinho.Domain.Interfaces.Repositorio
{
    public interface IRepository<TEntity> where TEntity : EntityBase
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