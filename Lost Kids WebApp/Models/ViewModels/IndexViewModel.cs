using Lost_Kids_WebApp.Models.Comments;
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

        public List<MainComment> MainComments { get; set; }

        public PagingInfo PagingInfo { get; set; }

    }
}
