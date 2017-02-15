using AutoMapper;

namespace Totosinho.App.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMap>();
                x.AddProfile<ViewModelToDomainMap>();
            });
        }
    }
}
