using Totosinho.Domain.Entidades;

namespace Totosinho.Domain.Interfaces.Servicos
{
    public interface IServidorServico : IServico<Servidor>
    {
        Servidor ObterPorTokenAcesso(string tokenAcesso);
    }
}