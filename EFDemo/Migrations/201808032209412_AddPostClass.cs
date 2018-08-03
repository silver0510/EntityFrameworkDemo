namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                        Content = c.String(),
                        BlogID = c.String(),
                        Blog_BlogID = c.Int(),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.Blogs", t => t.Blog_BlogID)
                .Index(t => t.Blog_BlogID);
            
            AddColumn("dbo.Blogs", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Blog_BlogID", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] { "Blog_BlogID" });
            DropColumn("dbo.Blogs", "Rating");
            DropTable("dbo.Posts");
        }
    }
}
