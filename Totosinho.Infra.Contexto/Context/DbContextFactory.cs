using System.Data.Entity;
using Totosinho.Domain.Interfaces.Contexto;

namespace Totosinho.Repositorio.Context
{
    public class DbContextFactory : IDbContextFactory
    {
        private readonly DbContext _context;

        public DbContextFactory()
        {
            _context = new TotosinhoContext();
        }

        public DbContext GetContext()
        {
            return _context;
        }
    }
}