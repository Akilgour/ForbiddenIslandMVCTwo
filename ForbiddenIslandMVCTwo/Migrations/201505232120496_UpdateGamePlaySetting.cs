namespace ForbiddenIslandMVCTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGamePlaySetting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GamePlaySettings", "FirstMovePlayerId", c => c.Guid());
            AddColumn("dbo.GamePlaySettings", "SecondMovePlayerId", c => c.Guid());
            AddColumn("dbo.GamePlaySettings", "ThirdMovePlayerId", c => c.Guid());
            AddColumn("dbo.GamePlaySettings", "FourthMovePlayerId", c => c.Guid());
            AddColumn("dbo.GamePlaySettings", "MoveNumber", c => c.Int(nullable: false));
            AddColumn("dbo.GamePlaySettings", "WaterLevelMarker", c => c.Int(nullable: false));
            AddColumn("dbo.GamePlaySettings", "DrawDeckId", c => c.Guid(nullable: false));
            AddColumn("dbo.GamePlaySettings", "DiscardDeckId", c => c.Guid(nullable: false));
            CreateIndex("dbo.GamePlaySettings", "FirstMovePlayerId");
            CreateIndex("dbo.GamePlaySettings", "SecondMovePlayerId");
            CreateIndex("dbo.GamePlaySettings", "ThirdMovePlayerId");
            CreateIndex("dbo.GamePlaySettings", "FourthMovePlayerId");
            AddForeignKey("dbo.GamePlaySettings", "FirstMovePlayerId", "dbo.Players", "Id");
            AddForeignKey("dbo.GamePlaySettings", "FourthMovePlayerId", "dbo.Players", "Id");
            AddForeignKey("dbo.GamePlaySettings", "SecondMovePlayerId", "dbo.Players", "Id");
            AddForeignKey("dbo.GamePlaySettings", "ThirdMovePlayerId", "dbo.Players", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GamePlaySettings", "ThirdMovePlayerId", "dbo.Players");
            DropForeignKey("dbo.GamePlaySettings", "SecondMovePlayerId", "dbo.Players");
            DropForeignKey("dbo.GamePlaySettings", "FourthMovePlayerId", "dbo.Players");
            DropForeignKey("dbo.GamePlaySettings", "FirstMovePlayerId", "dbo.Players");
            DropIndex("dbo.GamePlaySettings", new[] { "FourthMovePlayerId" });
            DropIndex("dbo.GamePlaySettings", new[] { "ThirdMovePlayerId" });
            DropIndex("dbo.GamePlaySettings", new[] { "SecondMovePlayerId" });
            DropIndex("dbo.GamePlaySettings", new[] { "FirstMovePlayerId" });
            DropColumn("dbo.GamePlaySettings", "DiscardDeckId");
            DropColumn("dbo.GamePlaySettings", "DrawDeckId");
            DropColumn("dbo.GamePlaySettings", "WaterLevelMarker");
            DropColumn("dbo.GamePlaySettings", "MoveNumber");
            DropColumn("dbo.GamePlaySettings", "FourthMovePlayerId");
            DropColumn("dbo.GamePlaySettings", "ThirdMovePlayerId");
            DropColumn("dbo.GamePlaySettings", "SecondMovePlayerId");
            DropColumn("dbo.GamePlaySettings", "FirstMovePlayerId");
        }
    }
}
