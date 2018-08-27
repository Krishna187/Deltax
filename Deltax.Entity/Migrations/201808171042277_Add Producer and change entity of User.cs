namespace Deltax.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProducerandchangeentityofUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producers", "UserId", "dbo.Users");
            DropIndex("dbo.Producers", new[] { "UserId" });
            DropTable("dbo.Producers");
        }
    }
}
