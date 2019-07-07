namespace CarConfigurator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCars : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT CARS ON");
            Sql("INSERT INTO CARS (Id, Name, Description, Price) VALUES (1, 'Convertible', 'A passenger car that can be driven with or without a roof in place.', 43988)");
            Sql("INSERT INTO CARS (Id, Name, Description, Price) VALUES (2, 'Coupé', 'A passenger car with a sloping rear roofline and two doors.', 38323)");
            Sql("INSERT INTO CARS (Id, Name, Description, Price) VALUES (3, 'Sedan', 'A passenger car with a sloping rear roofline and four doors.', 32990)");
            Sql("INSERT INTO CARS (Id, Name, Description, Price) VALUES (4, 'Roadster', 'An open two seat car with emphasis on sporting appearance or character.', 40800)");
            Sql("INSERT INTO CARS (Id, Name, Description, Price) VALUES (5, 'SUV', 'A passenger car with raised ground clearance and four wheel drive.', 40800)");
            Sql("SET IDENTITY_INSERT CARS OFF");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM CARS WHERE Id BETWEEN 1 AND 5");
        }
    }
}
