namespace Totosinho.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationinitial : DbMigration
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
                        servidor_cod = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.player_id, name: "IX_PLAYER_ID")
                .Index(t => t.game_id, name: "IX_GAME_ID")
                .Index(t => t.servidor_cod, name: "IX_SERVIDOR_COD");
            
            CreateTable(
                "dbo.Servidor",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        AcessToken = c.String(maxLength: 50, unicode: false),
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
