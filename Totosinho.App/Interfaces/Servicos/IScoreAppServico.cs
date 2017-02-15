using System.Threading.Tasks;
using Totosinho.App.ViewModels.Servicos;
using Totosinho.Domain.Entidades;

namespace Totosinho.App.Interfaces.Servicos
{
    public interface IScoreAppServico
    {
        ScoreViewModel Add(ScoreViewModel obj);
    }
}
