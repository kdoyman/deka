namespace tip4trip_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Me_lathos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "nameloc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "nameloc");
        }
    }
}
