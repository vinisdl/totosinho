using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totosinho.Domain.Entities;
using Totosinho.Domain.Interfaces.Repository;
using Totosinho.Repositorio.Context;

namespace Totosinho.Repositorio.Repository
{
    public class ScoreRepository : Repository<Score>, IScoreRepository
    {
        public ScoreRepository(TotosinhoContext context) : base(context)
        {
            
        }
    }
}
