namespace TryItOut.DataAccessEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PendingChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LocomotiveClassifications",
                c => new
                    {
                        ClassificationId = c.Int(nullable: false, identity: true),
                        Power = c.String(maxLength: 50),
                        Classification = c.String(maxLength: 50),
                        Comments = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ClassificationId);
            
            AddColumn("dbo.Locomotives", "Classification", c => c.Int());
            DropColumn("dbo.Locomotives", "Type");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LocomotiveTypes",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 50),
                        Classification = c.String(maxLength: 50),
                        Comments = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.TypeId);
            
            AddColumn("dbo.Locomotives", "Type", c => c.Int());
            DropColumn("dbo.Locomotives", "Classification");
            DropTable("dbo.LocomotiveClassifications");
        }
    }
}
