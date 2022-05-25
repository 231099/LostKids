using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models.Comments
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }

        public DateTime Created { get; set; }
        public string UserName { get; set; }
    }
}
