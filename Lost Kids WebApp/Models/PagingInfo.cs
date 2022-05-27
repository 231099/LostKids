using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models
{
    public class PagingInfo
    {
        public int TotalRecords { get; set; }

        public int RecordsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((decimal)TotalRecords / RecordsPerPage);

        public string UrlParam { get; set; }
    }
}
