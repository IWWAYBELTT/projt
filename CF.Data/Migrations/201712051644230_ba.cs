namespace CF.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ba : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departement",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        EnrollmentNumber = c.String(nullable: false),
                        depID = c.Int(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departement", t => t.depID, cascadeDelete: true)
                .Index(t => t.depID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "depID", "dbo.Departement");
            DropIndex("dbo.Student", new[] { "depID" });
            DropTable("dbo.Student");
            DropTable("dbo.Departement");
        }
    }
}
