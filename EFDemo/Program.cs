using EFDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new BlogDbContext())
            {
                Blog blog = new Blog() { BlogID = 1, BlogName = "First Blog" };
                db.Blogs.Add(blog);
                db.SaveChanges();

                var query = db.Blogs.Select(bl => bl).ToList();
                foreach(var bl in query)
                {
                    Console.WriteLine("BlogID: {0} - BlogName: {1}", bl.BlogID, bl.BlogName);
                }

                Console.ReadLine();
            }
        }
    }
}
