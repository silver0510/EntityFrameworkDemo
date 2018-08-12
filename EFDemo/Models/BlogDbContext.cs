using EFDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo.Migrations;

namespace EFDemo.Models
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext(): base("BlogDemo")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDbContext,Configuration>());
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
