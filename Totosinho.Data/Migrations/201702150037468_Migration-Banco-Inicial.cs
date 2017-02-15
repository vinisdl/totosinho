using System.Data.Entity.Migrations;

namespace Totosinho.Repositorio.Migrations
{
    public partial class MigrationBancoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Score",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        player_id = c.Long(nullable: false),
                        game_id = c.Long(nullable: false),
                        win = c.Long(nullable: false),
                        timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.player_id, name: "IX_PLAYER_ID")
                .Index(t => t.game_id, name: "IX_GAME_ID");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Score", "IX_GAME_ID");
            DropIndex("dbo.Score", "IX_PLAYER_ID");
            DropTable("dbo.Score");
        }
    }
}
