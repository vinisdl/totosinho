using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
