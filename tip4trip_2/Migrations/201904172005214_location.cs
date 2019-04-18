namespace tip4trip_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class location : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Houses", "LocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.Locations", "nameloc", c => c.String(nullable: false));
            CreateIndex("dbo.Houses", "LocationId");
            AddForeignKey("dbo.Houses", "LocationId", "dbo.Locations", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Houses", "LocationId", "dbo.Locations");
            DropIndex("dbo.Houses", new[] { "LocationId" });
            AlterColumn("dbo.Locations", "nameloc", c => c.String());
            DropColumn("dbo.Houses", "LocationId");
        }
    }
}
