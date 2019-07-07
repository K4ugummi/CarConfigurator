namespace CarConfigurator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGuidToCarConfiguration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarConfigurations", "Guid", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarConfigurations", "Guid");
        }
    }
}
