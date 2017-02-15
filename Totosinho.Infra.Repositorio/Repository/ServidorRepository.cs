using System.Linq;
using Totosinho.Domain.Entidades;
using Totosinho.Domain.Interfaces.Contexto;
using Totosinho.Domain.Interfaces.Repositorio;

namespace Totosinho.Infra.Repositorio.Repository
{
    public class ServidorRepository : Repository<Servidor>, IServidorRepository
    {
        public ServidorRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public Servidor ObterPorTokenAcesso(string acessToken)
        {
            return Get().FirstOrDefault(a => a.AcessToken.Equals(acessToken));
        }
    }
}