using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models.Comments
{
    public class MainComment: Comment
    {
        public List<SubComment> SubComments { get; set; }
    }
}
