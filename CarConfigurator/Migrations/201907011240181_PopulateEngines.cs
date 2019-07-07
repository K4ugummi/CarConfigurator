namespace CarConfigurator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEngines : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT ENGINES ON");
            Sql("INSERT INTO ENGINES (Id, KiloWatts, Name, Description, Price) VALUES (1, 95, '160i', '1.6 litres gas engine', 0)");
            Sql("INSERT INTO ENGINES (Id, KiloWatts, Name, Description, Price) VALUES (2, 115, '180i', '1.8 litres gas engine', 2000)");
            Sql("INSERT INTO ENGINES (Id, KiloWatts, Name, Description, Price) VALUES (3, 135, '200i', '2.0 litres gas engine', 3500)");
            Sql("INSERT INTO ENGINES (Id, KiloWatts, Name, Description, Price) VALUES (4, 190, '300i', '3.0 litres gas engine', 6000)");
            Sql("INSERT INTO ENGINES (Id, KiloWatts, Name, Description, Price) VALUES (5, 245, '400i', '4.0 litres gas engine', 10000)");
            Sql("SET IDENTITY_INSERT ENGINES OFF");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM ENGINES WHERE Id BETWEEN 1 AND 5");
        }
    }
}
