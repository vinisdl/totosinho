using System.Data.Entity;
using System.Data.Entity.Migrations;
using Totosinho.Domain.Entidades;

namespace Totosinho.Repositorio.Context.Seed
{
    public class TotosinhoDbInitializer : CreateDatabaseIfNotExists<TotosinhoContext>
    {
        protected override void Seed(TotosinhoContext context)
        {
            var serv = new Servidor();
            serv.SetAcessToken("72571b66-805a-40f4-9869-06e8c633a0a5");
            context.Servidor.AddOrUpdate(serv);
            context.SaveChanges();
        }
    }
}