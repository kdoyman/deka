namespace tip4trip_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tetarth17 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Locations");
        }
    }
}
