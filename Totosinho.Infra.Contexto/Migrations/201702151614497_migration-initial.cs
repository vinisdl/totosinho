using System.Data.Entity.Migrations;

namespace Totosinho.Repositorio.Migrations
{
    public partial class migrationinitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Score",
                    c => new
                    {
                        Id = c.Long(false, true),
                        player_id = c.Long(false),
                        game_id = c.Long(false),
                        win = c.Long(false),
                        timestamp = c.DateTime(false),
                        servidor_cod = c.Long(false)
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.player_id, "IX_PLAYER_ID")
                .Index(t => t.game_id, "IX_GAME_ID")
                .Index(t => t.servidor_cod, "IX_SERVIDOR_COD");

            CreateTable(
                    "dbo.Servidor",
                    c => new
                    {
                        Id = c.Long(false, true),
                        AcessToken = c.String(maxLength: 50, unicode: false)
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropIndex("dbo.Score", "IX_SERVIDOR_COD");
            DropIndex("dbo.Score", "IX_GAME_ID");
            DropIndex("dbo.Score", "IX_PLAYER_ID");
            DropTable("dbo.Servidor");
            DropTable("dbo.Score");
        }
    }
}