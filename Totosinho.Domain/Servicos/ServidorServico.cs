using Totosinho.Domain.Entidades;
using Totosinho.Domain.Interfaces.Repositorio;
using Totosinho.Domain.Interfaces.Servicos;

namespace Totosinho.Domain.Servicos
{
    public class ServidorServico : Servico<Servidor>, IServidorServico
    {
        private readonly IServidorRepository _repositorio;

        public ServidorServico(IServidorRepository repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }

        public Servidor ObterPorTokenAcesso(string tokenAcesso)
        {
            return _repositorio.ObterPorTokenAcesso(tokenAcesso);
        }
    }
}
