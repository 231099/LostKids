using Lost_Kids_WebApp.Models.Comments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models.ViewModels
{
    public class CommentViewModel
    {
        [Required]
        public int PostId { get; set; }
        [Required]
        public int MainCommentId { get; set; }
        [Required]
        public string Messsage { get; set; }
        [Required]
        public string UserName { get; set; }

        public IEnumerable<MainComment> MainComments { get; set; }
    }
}
