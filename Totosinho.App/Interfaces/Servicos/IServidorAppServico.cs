using Totosinho.App.ViewModels.Servicos;

namespace Totosinho.App.Interfaces.Servicos
{
    public interface IServidorAppServico
    {
        ServidorViewModel ObterPorTokenAcesso(string tokenAcesso);
    }
}