using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totosinho.Domain.Entities;

namespace Totosinho.Domain.Interfaces.App
{
    public interface IScoreAppServico
    {
        void Add(ScoreViewModel obj);
    }
}
