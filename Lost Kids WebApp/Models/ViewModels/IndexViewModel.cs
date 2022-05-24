using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Post> Posts { get; set; }

        public IEnumerable <Category> Categories { get; set; }

        public Comment Comments { get; set; }
        public IEnumerable<Comment> comments { get; set; }

    }
}
