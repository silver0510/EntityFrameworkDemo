using EFDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Models
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext(): base("BlogDemo")
        {
           
        }

        public DbSet<Blog> Blogs { get; set; }
    }
}
