using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Models
{
    public class Post
    {
        public int PostID { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public string Content { get; set; }

        public string BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
