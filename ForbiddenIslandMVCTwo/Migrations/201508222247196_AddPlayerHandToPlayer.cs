namespace ForbiddenIslandMVCTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlayerHandToPlayer : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.TreasureCards", "PlayerId");
            AddForeignKey("dbo.TreasureCards", "PlayerId", "dbo.Players", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TreasureCards", "PlayerId", "dbo.Players");
            DropIndex("dbo.TreasureCards", new[] { "PlayerId" });
        }
    }
}
