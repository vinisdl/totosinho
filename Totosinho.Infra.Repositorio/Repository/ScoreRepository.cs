using Totosinho.Domain.Entidades;
using Totosinho.Domain.Interfaces.Contexto;
using Totosinho.Domain.Interfaces.Repositorio;

namespace Totosinho.Infra.Repositorio.Repository
{
    public class ScoreRepository : Repository<Score>, IScoreRepository
    {
        public ScoreRepository(IUnitOfWork uow)
            : base(uow)
        {            
        }
    }
}
