namespace CarConfigurator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRims : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT RIMS ON");
            Sql("INSERT INTO RIMS (Id, Diameter, Color, Name, Description, Price) VALUES (1, 16, 'Grey', '10-Spoke-Design', 'Basic 10-spoke-design alimunium rims', 0)");
            Sql("INSERT INTO RIMS (Id, Diameter, Color, Name, Description, Price) VALUES (2, 17, 'Grey', '10-Spoke-Design', 'Slightly bigger 10-spoke-design alimunium rims', 850)");
            Sql("INSERT INTO RIMS (Id, Diameter, Color, Name, Description, Price) VALUES (3, 18, 'Black and grey', 'Multy-Spoke-Design', 'Elegant multy spoke design rims', 1700)");
            Sql("INSERT INTO RIMS (Id, Diameter, Color, Name, Description, Price) VALUES (4, 19, 'Black', 'AMB 5-Spoke-Design', 'Sporty 5 spoke design rims', 2000)");
            Sql("SET IDENTITY_INSERT RIMS OFF");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM RIMS WHERE Id BETWEEN 1 AND 4");
        }
    }
}
