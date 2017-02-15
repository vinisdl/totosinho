using System.Configuration;
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
            : base(GetSqlConnection())
        {
            Database.SetInitializer(new TotosinhoDbInitializer());
            Configuration.LazyLoadingEnabled = false;
        }


        public DbSet<Servidor> Servidor { get; set; }
        public DbSet<Score> Score { get; set; }

        public static string GetSqlConnection()
        {
            string _connectionString;
            var ambiente = ConfigurationManager.AppSettings["ambiente"].ToLower();
            switch (ambiente)
            {
                case "producao":
                    _connectionString =
                        ConfigurationManager.ConnectionStrings["DefaultConnectionProducao"].ConnectionString;
                    break;
                case "teste":
                    _connectionString =
                        ConfigurationManager.ConnectionStrings["DefaultConnectionTeste"].ConnectionString;
                    break;
                case "dev":
                    _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionDev"].ConnectionString;
                    break;
                default:
                    _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionDev"].ConnectionString;
                    break;
            }
            return _connectionString;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(a => a.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(a => a.HasMaxLength(50));


            modelBuilder.Configurations.Add(new ScoreConfiguration());
        }
    }
}