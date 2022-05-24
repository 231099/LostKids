using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        public DateTime CreationTime { get; set; }

        public string CommentDescription { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("PostId")]
        public int postid { get; set; }

        public Post Post { get; set; }
    }
}
