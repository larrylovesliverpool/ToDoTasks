namespace TryItOut.DataAccessEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Decoder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RailwaysDecoders",
                c => new
                    {
                        DecoderId = c.Int(nullable: false, identity: true),
                        Manufacturer = c.Int(nullable: false),
                        StayALive = c.Boolean(nullable: false),
                        Type = c.String(maxLength: 50),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.DecoderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RailwaysDecoders");
        }
    }
}
