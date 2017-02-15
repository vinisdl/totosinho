using System.Data.Entity;

namespace Totosinho.Domain.Interfaces.Contexto
{
    public interface IDbContextFactory
    {
        DbContext GetContext();
    }
}
