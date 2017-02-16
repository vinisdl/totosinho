using SimpleInjector;
using Totosinho.App.Interfaces.Servicos;
using Totosinho.App.Servicos;
using Totosinho.Domain.Interfaces.Contexto;
using Totosinho.Domain.Interfaces.Repositorio;
using Totosinho.Domain.Interfaces.Servicos;
using Totosinho.Domain.Servicos;
using Totosinho.Infra.Repositorio.Repository;
using Totosinho.Repositorio;
using Totosinho.Repositorio.Context;

namespace Totosinho.Infra.CrossCutting.IoC
{
    public static class BootStrapper
    {
        public static void Register(Container container)
        {
            //Context
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<IDbContextFactory, DbContextFactory>(Lifestyle.Scoped);
            //Servidor
            container.Register<IServidorServico, ServidorServico>(Lifestyle.Scoped);
            container.Register<IServidorAppServico, ServidorAppServico>(Lifestyle.Scoped);
            container.Register<IServidorRepository, ServidorRepository>(Lifestyle.Scoped);

            //GameResult
            container.Register<IGameResultServico, GameResultServico>(Lifestyle.Scoped);
            container.Register<IGameResultAppServico, GameResultAppServico>(Lifestyle.Scoped);
            container.Register<IGameResultRepository, GameResultRepository>(Lifestyle.Scoped);
        }
    }
}