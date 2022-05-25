using Lost_Kids_WebApp.Models.Comments;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Descripition { get; set; }

        public string  Image { get; set; }

        public string Address{ get; set; }

        [Display(Name ="Category")]
        public int CategoryId{ get; set; }

        [ForeignKey("CategoryId")]
        public Category Category{ get; set; }

        [Display(Name = "Sub-Category")]
        public int SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")]
        public SubCategory SubCategory { get; set; }

        
        public string AuthorId { get; set; }

        [Required]
        [Display(Name = "Author-Name")]
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }

        public string Status { get; set; }

        public string PhoneNumber{ get; set; }

        public bool IsFounded { get; set; }

        public List<MainComment> MainComments{ get; set; }
    }
}
