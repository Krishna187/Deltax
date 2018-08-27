namespace Deltax.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserandActorClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Bio = c.String(nullable: false, maxLength: 1000),
                        Sex = c.Int(nullable: false),
                        Dob = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Actors", "UserId", "dbo.Users");
            DropIndex("dbo.Actors", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Actors");
        }
    }
}
