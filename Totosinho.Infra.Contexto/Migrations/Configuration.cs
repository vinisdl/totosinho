using Totosinho.Repositorio.Context.Seed;

namespace Totosinho.Repositorio.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Totosinho.Repositorio.Context.TotosinhoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Totosinho.Repositorio.Context.TotosinhoContext context)
        {
        }
    }
}
