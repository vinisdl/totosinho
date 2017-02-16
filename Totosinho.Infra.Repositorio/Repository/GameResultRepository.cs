using Totosinho.Domain.Entidades;
using Totosinho.Domain.Interfaces.Contexto;
using Totosinho.Domain.Interfaces.Repositorio;

namespace Totosinho.Infra.Repositorio.Repository
{
    public class GameResultRepository : Repository<GameResult>, IGameResultRepository
    {
        public GameResultRepository(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}