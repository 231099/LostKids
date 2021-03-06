using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Sub-Category ")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Category")]

        public int CategoryId { get; set; }
       
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}