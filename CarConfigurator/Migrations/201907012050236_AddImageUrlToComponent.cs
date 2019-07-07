namespace CarConfigurator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageUrlToComponent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "ImageURL", c => c.String());
            AddColumn("dbo.Engines", "ImageURL", c => c.String());
            AddColumn("dbo.Extras", "ImageURL", c => c.String());
            AddColumn("dbo.Paints", "ImageURL", c => c.String());
            AddColumn("dbo.Rims", "ImageURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rims", "ImageURL");
            DropColumn("dbo.Paints", "ImageURL");
            DropColumn("dbo.Extras", "ImageURL");
            DropColumn("dbo.Engines", "ImageURL");
            DropColumn("dbo.Cars", "ImageURL");
        }
    }
}
