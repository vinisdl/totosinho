using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Totosinho.Domain.Entidades;

namespace Totosinho.Repositorio.EntityTypesConfigurations
{
    public class ScoreConfiguration : EntityTypeConfiguration<Score>
    {
        public ScoreConfiguration()
        {
            HasKey(u => u.Id);

            Property(x => x.PlayerId)
               .HasColumnName("player_id")
               .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_PLAYER_ID", 1)));
            Property(x => x.GameId)
              .HasColumnName("game_id")
              .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_GAME_ID", 2)));

            Property(a => a.Win).HasColumnName("win");
            Property(a => a.TimeStamp).HasColumnName("timestamp");
            Property(a => a.ServidorCod).HasColumnName("servidor_cod")
             .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_SERVIDOR_COD", 3)));


        }
    }
}
