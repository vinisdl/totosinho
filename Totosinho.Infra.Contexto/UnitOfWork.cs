using System;
using System.Data.Entity;
using Totosinho.Domain.Interfaces.Contexto;

namespace Totosinho.Repositorio
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private bool disposed;

        public UnitOfWork(IDbContextFactory contextFactory)
        {
            Context = contextFactory.GetContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void SaveChanges()
        {
            if (Context != null)
                Context.SaveChanges();
        }

        public DbContext Context { get; }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    Context.Dispose();
            disposed = true;
        }
    }
}