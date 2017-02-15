using AutoMapper;
using Totosinho.App.ViewModels.Servicos;
using Totosinho.Domain.Entidades;

namespace Totosinho.App.AutoMapper
{
    internal class ViewModelToDomainMap : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMap"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ServidorViewModel, Servidor>();
            Mapper.CreateMap<ScoreViewModel, Score>();
        }
    }
}