namespace ForbiddenIslandMVCTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GamePlaySettings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TreasureCards",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Action = c.String(),
                        TreasureCardType = c.String(),
                        Order = c.Int(nullable: false),
                        DeckTheCardIsIn = c.String(),
                        GameId = c.Guid(nullable: false),
                        GamePlaySetting_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GamePlaySettings", t => t.GamePlaySetting_Id)
                .Index(t => t.GamePlaySetting_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TreasureCards", "GamePlaySetting_Id", "dbo.GamePlaySettings");
            DropIndex("dbo.TreasureCards", new[] { "GamePlaySetting_Id" });
            DropTable("dbo.TreasureCards");
            DropTable("dbo.GamePlaySettings");
        }
    }
}
