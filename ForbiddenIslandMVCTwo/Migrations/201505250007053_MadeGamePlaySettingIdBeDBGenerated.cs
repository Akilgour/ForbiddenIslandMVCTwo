namespace ForbiddenIslandMVCTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeGamePlaySettingIdBeDBGenerated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TreasureCards", "GamePlaySetting_Id", "dbo.GamePlaySettings");
            DropPrimaryKey("dbo.GamePlaySettings");
            AlterColumn("dbo.GamePlaySettings", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.GamePlaySettings", "Id");
            AddForeignKey("dbo.TreasureCards", "GamePlaySetting_Id", "dbo.GamePlaySettings", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TreasureCards", "GamePlaySetting_Id", "dbo.GamePlaySettings");
            DropPrimaryKey("dbo.GamePlaySettings");
            AlterColumn("dbo.GamePlaySettings", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.GamePlaySettings", "Id");
            AddForeignKey("dbo.TreasureCards", "GamePlaySetting_Id", "dbo.GamePlaySettings", "Id");
        }
    }
}
