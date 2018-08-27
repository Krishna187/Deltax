namespace Deltax.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bytearraysettonullinposter : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Poster");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Poster", c => c.Binary());
        }
    }
}
