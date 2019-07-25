namespace TryItOut.DataAccessEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialRailways : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DecoderCVValues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DecoderId = c.Int(nullable: false),
                        LocomotiveId = c.Int(nullable: false),
                        CVNumber = c.Int(nullable: false),
                        CVDescription = c.String(maxLength: 50),
                        CVValue = c.String(),
                        Name = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locomotives",
                c => new
                    {
                        LocoId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Type = c.Int(),
                        MadeBy = c.Int(),
                        Decoder = c.Int(),
                        DCCValue = c.Int(),
                        Description = c.String(),
                        YearPurchased = c.Int(),
                    })
                .PrimaryKey(t => t.LocoId);
            
            CreateTable(
                "dbo.RailwaysManufacturers",
                c => new
                    {
                        ManufacturerId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ManufacturerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RailwaysManufacturers");
            DropTable("dbo.Locomotives");
            DropTable("dbo.DecoderCVValues");
        }
    }
}
