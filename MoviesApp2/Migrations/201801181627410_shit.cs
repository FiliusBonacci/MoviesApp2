namespace MoviesApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reviews", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "UserId", c => c.Int(nullable: false));
        }
    }
}
