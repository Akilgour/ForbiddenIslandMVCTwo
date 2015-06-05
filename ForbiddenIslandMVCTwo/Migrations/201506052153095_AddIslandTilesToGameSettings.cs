namespace ForbiddenIslandMVCTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIslandTilesToGameSettings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IslandTiles", "GamePlaySetting_Id", c => c.Guid());
            CreateIndex("dbo.IslandTiles", "GamePlaySetting_Id");
            AddForeignKey("dbo.IslandTiles", "GamePlaySetting_Id", "dbo.GamePlaySettings", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IslandTiles", "GamePlaySetting_Id", "dbo.GamePlaySettings");
            DropIndex("dbo.IslandTiles", new[] { "GamePlaySetting_Id" });
            DropColumn("dbo.IslandTiles", "GamePlaySetting_Id");
        }
    }
}
