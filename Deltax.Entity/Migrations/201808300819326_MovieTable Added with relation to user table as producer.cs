namespace Deltax.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieTableAddedwithrelationtousertableasproducer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ActorMovies", "Movie_MovieId", "dbo.Movie");
            DropPrimaryKey("dbo.Movie");
            AddColumn("dbo.User", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Movie", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Movie", "Id");
            CreateIndex("dbo.Movie", "Id");
            AddForeignKey("dbo.Movie", "Id", "dbo.User", "Id");
            AddForeignKey("dbo.ActorMovies", "Movie_MovieId", "dbo.Movie", "Id", cascadeDelete: true);
            DropColumn("dbo.Movie", "PosterURL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "PosterURL", c => c.String());
            DropForeignKey("dbo.ActorMovies", "Movie_MovieId", "dbo.Movie");
            DropForeignKey("dbo.Movie", "Id", "dbo.User");
            DropIndex("dbo.Movie", new[] { "Id" });
            DropPrimaryKey("dbo.Movie");
            AlterColumn("dbo.Movie", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.User", "Discriminator");
            AddPrimaryKey("dbo.Movie", "Id");
            AddForeignKey("dbo.ActorMovies", "Movie_MovieId", "dbo.Movie", "Id", cascadeDelete: true);
        }
    }
}
