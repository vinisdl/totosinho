using Totosinho.Domain.Entidades;

namespace Totosinho.Domain.Interfaces.Repositorio
{
    public interface IServidorRepository : IRepository<Servidor>
    {
        Servidor ObterPorTokenAcesso(string tokenAcesso);
    }
}
