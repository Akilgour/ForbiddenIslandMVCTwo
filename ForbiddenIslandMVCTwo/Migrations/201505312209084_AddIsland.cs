namespace ForbiddenIslandMVCTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsland : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Islands",
                c => new
                    {
                        Id = c.Guid(nullable: false, defaultValue: Guid.NewGuid()),
                        MoveOne = c.Guid(nullable: false),
                        MoveTwo = c.Guid(nullable: false),
                        MoveThree = c.Guid(nullable: false),
                        CurrentPlayerId = c.Guid(nullable: false),
                        GameId = c.Guid(nullable: false),
                        GamePlaySetting_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GamePlaySettings", t => t.GamePlaySetting_Id)
                .Index(t => t.GamePlaySetting_Id);
            
            AddColumn("dbo.Players", "IslandTile_Id", c => c.Guid());
            AddColumn("dbo.IslandTiles", "Island_Id", c => c.Guid());
            CreateIndex("dbo.Players", "IslandTile_Id");
            CreateIndex("dbo.IslandTiles", "Island_Id");
            AddForeignKey("dbo.Players", "IslandTile_Id", "dbo.IslandTiles", "Id");
            AddForeignKey("dbo.IslandTiles", "Island_Id", "dbo.Islands", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IslandTiles", "Island_Id", "dbo.Islands");
            DropForeignKey("dbo.Players", "IslandTile_Id", "dbo.IslandTiles");
            DropForeignKey("dbo.Islands", "GamePlaySetting_Id", "dbo.GamePlaySettings");
            DropIndex("dbo.IslandTiles", new[] { "Island_Id" });
            DropIndex("dbo.Islands", new[] { "GamePlaySetting_Id" });
            DropIndex("dbo.Players", new[] { "IslandTile_Id" });
            DropColumn("dbo.IslandTiles", "Island_Id");
            DropColumn("dbo.Players", "IslandTile_Id");
            DropTable("dbo.Islands");
        }
    }
}
