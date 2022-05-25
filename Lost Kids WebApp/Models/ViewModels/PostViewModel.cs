using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models.ViewModels
{
    public class PostViewModel
    {
        public Post  Post{ get; set; }

        public IEnumerable<Category> categoriesList{ get; set; }

        public IEnumerable<SubCategory> subCategoriesList{ get; set; }

        

    }
}
