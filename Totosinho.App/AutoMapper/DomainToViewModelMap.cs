using AutoMapper;
using Totosinho.App.ViewModels.Servicos;
using Totosinho.Domain.Entidades;

namespace Totosinho.App.AutoMapper
{
    internal class DomainToViewModelMap : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMap"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Servidor, ServidorViewModel>();
            Mapper.CreateMap<GameResult, GameResultViewModel>();
        }
    }
}