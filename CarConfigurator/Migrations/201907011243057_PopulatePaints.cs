namespace CarConfigurator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePaints : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT PAINTS ON");
            Sql("INSERT INTO PAINTS (Id, Name, Description, Price) VALUES (1, 'Black', 'Uniform black color', 0)");
            Sql("INSERT INTO PAINTS (Id, Name, Description, Price) VALUES (2, 'Designo White', 'Designo diamond bright white color', 1700)");
            Sql("INSERT INTO PAINTS (Id, Name, Description, Price) VALUES (3, 'Designo Red', 'Designo diamond bright red color', 1500)");
            Sql("INSERT INTO PAINTS (Id, Name, Description, Price) VALUES (4, 'Metallic Brilliantblue', 'Metallic brilliant blue color', 900)");
            Sql("INSERT INTO PAINTS (Id, Name, Description, Price) VALUES (5, 'Metallic Graphitgrey', 'Metallic graphit grey color', 900)");
            Sql("INSERT INTO PAINTS (Id, Name, Description, Price) VALUES (6, 'Metallic Obsidianblack', 'Metallic obsidian black color', 900)");
            Sql("SET IDENTITY_INSERT PAINTS OFF");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM PAINTS WHERE Id BETWEEN 1 AND 6");
        }
    }
}
