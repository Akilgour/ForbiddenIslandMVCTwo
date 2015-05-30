namespace ForbiddenIslandMVCTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GiveTreasureCardAPlayerId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TreasureCards", "PlayerId", c => c.Guid());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TreasureCards", "PlayerId");
        }
    }
}
