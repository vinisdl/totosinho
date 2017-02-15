using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Totosinho.Domain.Entidades;
using Totosinho.Repositorio.Context.Seed;
using Totosinho.Repositorio.EntityTypesConfigurations;

namespace Totosinho.Repositorio.Context
{
    public class TotosinhoContext : DbContext
    {
        public TotosinhoContext()
            : base("DefaultConnectionDev")
        {
            Database.SetInitializer(new TotosinhoDbInitializer());
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Servidor> Servidor { get; set; }
        public DbSet<Score> Score { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(a=>a.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(a=>a.HasMaxLength(50));


            modelBuilder.Configurations.Add(new ScoreConfiguration());

        }
    }
}
