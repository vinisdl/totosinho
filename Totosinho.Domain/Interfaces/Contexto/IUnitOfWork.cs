using System.Data.Entity;

namespace Totosinho.Domain.Interfaces.Contexto
{
    public interface IUnitOfWork
    {
        DbContext Context { get; }
        void SaveChanges();
    }
}