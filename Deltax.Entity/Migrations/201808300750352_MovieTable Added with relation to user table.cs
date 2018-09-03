namespace Deltax.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieTableAddedwithrelationtousertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieName = c.String(maxLength: 255),
                        YearOfRelease = c.Int(nullable: false),
                        Plot = c.String(),
                        PosterURL = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 255),
                        Sex = c.Int(nullable: false),
                        Dob = c.DateTime(),
                        Bio = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ActorMovies",
                c => new
                    {
                        Actor_UserId = c.Int(nullable: false),
                        Movie_MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Actor_UserId, t.Movie_MovieId })
                .ForeignKey("dbo.User", t => t.Actor_UserId, cascadeDelete: false)
                .ForeignKey("dbo.Movie", t => t.Movie_MovieId, cascadeDelete: false)
                .Index(t => t.Actor_UserId)
                .Index(t => t.Movie_MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ActorMovies", "Movie_MovieId", "dbo.Movie");
            DropForeignKey("dbo.ActorMovies", "Actor_UserId", "dbo.User");
            DropIndex("dbo.ActorMovies", new[] { "Movie_MovieId" });
            DropIndex("dbo.ActorMovies", new[] { "Actor_UserId" });
            DropTable("dbo.ActorMovies");
            DropTable("dbo.User");
            DropTable("dbo.Movie");
        }
    }
}
