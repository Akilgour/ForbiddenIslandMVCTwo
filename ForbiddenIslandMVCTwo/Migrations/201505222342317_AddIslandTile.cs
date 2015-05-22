namespace ForbiddenIslandMVCTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIslandTile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IslandTiles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        SubmergedState = c.String(),
                        StartingTileForPlayer = c.String(),
                        HelicopterSite = c.Boolean(nullable: false),
                        RowNumber = c.Int(nullable: false),
                        ColumnNumber = c.Int(nullable: false),
                        HasStatue = c.Boolean(nullable: false),
                        CanHaveStatue = c.String(),
                        GameId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.IslandTiles");
        }
    }
}
