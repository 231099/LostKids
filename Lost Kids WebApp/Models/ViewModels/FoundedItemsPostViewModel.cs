using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models.ViewModels
{
    public class FoundedItemsPostViewModel
    {
        public List<Post> Posts{ get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
