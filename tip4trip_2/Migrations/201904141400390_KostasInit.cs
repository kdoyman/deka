namespace tip4trip_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KostasInit : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Houses");
        }
    }
}
