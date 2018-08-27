namespace Deltax.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddproducerandMovierelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ProducerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Producers", "Id");
            AddForeignKey("dbo.Producers", "Id", "dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producers", "Id", "dbo.Movies");
            DropIndex("dbo.Producers", new[] { "Id" });
            DropColumn("dbo.Movies", "ProducerId");
        }
    }
}
