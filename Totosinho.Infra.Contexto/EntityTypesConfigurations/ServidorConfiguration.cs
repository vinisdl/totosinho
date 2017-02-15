using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Totosinho.Domain.Entidades;

namespace Totosinho.Repositorio.EntityTypesConfigurations
{
    public class ServidorConfiguration : EntityTypeConfiguration<Servidor>
    {
        public ServidorConfiguration()
        {
            HasKey(u => u.Id);

            Property(x => x.AcessToken)
                .HasColumnName("acess_token")
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_ACESS_TOKEN", 1)));
        }
    }
}