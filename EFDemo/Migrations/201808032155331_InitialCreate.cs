namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogID = c.Int(nullable: false, identity: true),
                        BlogName = c.String(),
                    })
                .PrimaryKey(t => t.BlogID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Blogs");
        }
    }
}
