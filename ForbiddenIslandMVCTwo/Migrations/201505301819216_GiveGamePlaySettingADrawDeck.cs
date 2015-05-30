namespace ForbiddenIslandMVCTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GiveGamePlaySettingADrawDeck : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TreasureCards", "DrawDeckId", c => c.Guid());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TreasureCards", "DrawDeckId");
        }
    }
}
