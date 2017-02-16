using Totosinho.Domain.Entidades;
using Totosinho.Domain.Interfaces.Repositorio;
using Totosinho.Domain.Interfaces.Servicos;

namespace Totosinho.Domain.Servicos
{
    public class GameResultServico : Servico<GameResult>, IGameResultServico
    {
        private readonly IGameResultRepository _repositorio;

        public GameResultServico(IGameResultRepository repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}