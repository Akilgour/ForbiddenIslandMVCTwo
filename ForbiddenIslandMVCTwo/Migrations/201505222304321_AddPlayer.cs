namespace ForbiddenIslandMVCTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlayer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Action = c.String(),
                        Colour = c.String(),
                        PlayerHandId = c.String(),
                        HasEarthStoneTreasureStatue = c.Boolean(nullable: false),
                        HasStatueOfTheWindTreasureStatue = c.Boolean(nullable: false),
                        HasCrystalOfFireTreasureStatue = c.Boolean(nullable: false),
                        HasOceansChaliceTreasureStatue = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
