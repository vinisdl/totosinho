using System.Collections.Generic;
using System.Linq;
using Totosinho.Domain.Entidades;
using Totosinho.Domain.Interfaces.Repositorio;
using Totosinho.Domain.Interfaces.Servicos;

namespace Totosinho.Domain.Servicos
{
    public class Servico<TEntity> : IServico<TEntity> where TEntity : EntityBase
    {
        private readonly IRepository<TEntity> _repositorio;

        public Servico(IRepository<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public TEntity Add(TEntity obj)
        {
            return _repositorio.Add(obj);
        }

        public void AddAll(IEnumerable<TEntity> obj)
        {
            foreach (var entity in obj)
                Add(entity);
        }

        public void DeleteAll(IEnumerable<TEntity> obj)
        {
            foreach (var entity in obj)
                Delete(entity);
        }

        public void Delete(TEntity obj)
        {
            _repositorio.Delete(obj);
        }

        public void Delete(int id)
        {
            _repositorio.Delete(Get(id));
        }

        public TEntity Get(int id)
        {
            return _repositorio.Get(id);
        }

        public TEntity First()
        {
            return _repositorio.First();
        }

        public IQueryable<TEntity> Get()
        {
            return _repositorio.Get();
        }

        public void Update(TEntity obj)
        {
            _repositorio.Update(obj);
            ;
        }

        public void AddOrUpdate(TEntity obj)
        {
            if (obj.Id > 0)
                Update(obj);
            else
                Add(obj);
        }

        public void Commit()
        {
            _repositorio.Commit();
        }
    }
}