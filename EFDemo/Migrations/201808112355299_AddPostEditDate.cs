namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostEditDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "DateTime");
        }
    }
}
