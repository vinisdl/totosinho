using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totosinho.Domain.Interfaces.Contexto;

namespace Totosinho.Repositorio
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext _context;
        private bool disposed = false;

        public UnitOfWork(IDbContextFactory contextFactory)
        {
            _context = contextFactory.GetContext();
        }

        public void SaveChanges()
        {
            if (_context != null)
            {
                _context.SaveChanges();
            }
        }

        public DbContext Context
        {
            get { return _context; }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
