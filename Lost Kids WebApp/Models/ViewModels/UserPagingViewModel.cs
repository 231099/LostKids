using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models.ViewModels
{
    public class UserPagingViewModel
    {
        public List<ApplicationUser> ApplicationUsers{ get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
