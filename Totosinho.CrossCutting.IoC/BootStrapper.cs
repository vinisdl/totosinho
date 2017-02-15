using SimpleInjector;
using Totosinho.App.Servicos;
using Totosinho.Domain.Interfaces;
using Totosinho.Domain.Interfaces.App;
using Totosinho.Domain.Interfaces.Repository;
using Totosinho.Repositorio.Repository;

namespace Totosinho.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<IScoreRepository, ScoreRepository>(Lifestyle.Scoped);
            container.Register<IScoreAppServico, ScoreAppServico>();
        }
    }
}