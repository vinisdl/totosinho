using Totosinho.Domain.Entidades;
using Totosinho.Domain.Interfaces.Repositorio;
using Totosinho.Domain.Interfaces.Servicos;

namespace Totosinho.Domain.Servicos
{
    public class ScoreServico : Servico<Score>, IScoreServico
    {
        private readonly IScoreRepository _repositorio;

        public ScoreServico(IScoreRepository repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }

    }
}
