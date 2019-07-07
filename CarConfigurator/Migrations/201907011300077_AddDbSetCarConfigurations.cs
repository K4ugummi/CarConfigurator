namespace CarConfigurator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDbSetCarConfigurations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarConfigurations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarID = c.Int(nullable: false),
                        EngineID = c.Int(nullable: false),
                        PaintID = c.Int(nullable: false),
                        RimID = c.Int(nullable: false),
                        Extra1 = c.Int(nullable: false),
                        Extra2 = c.Int(nullable: false),
                        Extra3 = c.Int(nullable: false),
                        Extra4 = c.Int(nullable: false),
                        Extra5 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarConfigurations");
        }
    }
}
