namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostCreateDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "CreateDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "CreateDate");
        }
    }
}
