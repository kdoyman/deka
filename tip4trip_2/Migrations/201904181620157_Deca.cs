namespace tip4trip_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false),
                        DateToRent = c.DateTime(nullable: false),
                        LocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nameloc = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Houses", "LocationId", "dbo.Locations");
            DropIndex("dbo.Houses", new[] { "LocationId" });
            DropTable("dbo.Locations");
            DropTable("dbo.Houses");
        }
    }
}
