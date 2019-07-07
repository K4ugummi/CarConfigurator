namespace CarConfigurator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateExtras : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT EXTRAS ON");
            Sql("INSERT INTO EXTRAS (Id, Name, Description, Price) VALUES (1, 'Heated front seats', 'Electrically heated front seats to take the chill out of even the coldest days', 600)");
            Sql("INSERT INTO EXTRAS (Id, Name, Description, Price) VALUES (2, 'Automatic climate control', 'Cools down the drivers- and passenger seat with individual temperaturs', 1600)");
            Sql("INSERT INTO EXTRAS (Id, Name, Description, Price) VALUES (3, 'Entry navigation', 'A precise, user friendly navigation system', 750)");
            Sql("INSERT INTO EXTRAS (Id, Name, Description, Price) VALUES (4, 'Power front seats', 'Electrically powered front seats with memory function for up to three drivers', 1200)");
            Sql("INSERT INTO EXTRAS (Id, Name, Description, Price) VALUES (5, '3D Soundsystem', '18 precisely placed speakers generate high fidelity sound', 980)");
            Sql("INSERT INTO EXTRAS (Id, Name, Description, Price) VALUES (6, 'Head-Up Display', 'The Head-Up Display projects a virtual image that appears to float in front of the windshield', 1050)");
            Sql("INSERT INTO EXTRAS (Id, Name, Description, Price) VALUES (7, 'Wireless charger', 'Advanced technology allows wireless charging of a compatible phone or other device', 170)");
            Sql("INSERT INTO EXTRAS (Id, Name, Description, Price) VALUES (8, 'Driver Assistance Package', 'Includes: Distance Assist, Steering Assist, Brake Assist, Speedlimit Assist, Automatic Stop-And-Go Assist', 2350)");
            Sql("INSERT INTO EXTRAS (Id, Name, Description, Price) VALUES (9, 'LED Headlamps', 'Enjoy the best view you ever had at night', 1430)");
            Sql("SET IDENTITY_INSERT EXTRAS OFF");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM EXTRAS WHERE Id BETWEEN 1 AND 9");
        }
    }
}
