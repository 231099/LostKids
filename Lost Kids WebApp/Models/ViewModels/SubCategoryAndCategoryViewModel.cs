using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models.ViewModels
{
    // this model is created to integrate two models the category and subcategory
    // model to be used in index view of subcategories
    
    public class SubCategoryAndCategoryViewModel
    {
        public IEnumerable <Category> CategoriesList { get; set; }
        public SubCategory SubCategory{ get; set; }


        public string StatusMessage { get; set; } //this is an error message to prevent duplicate when creating subcategory
    }
}
