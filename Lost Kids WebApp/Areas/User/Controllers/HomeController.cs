using Lost_Kids_WebApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lost_Kids_WebApp.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Lost_Kids_WebApp.Utility;
using Lost_Kids_WebApp.Models;
using System.Text;
using System.Security.Claims;

namespace Lost_Kids_WebApp.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;
        private bool like;

        [BindProperty]
        public PostViewModel PostVM { get; set; }
        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
            PostVM = new PostViewModel()
            {
                Post = new Post(),
                categoriesList = db.Categories.ToList()

            };
        }
        public async Task <IActionResult> Index()
        {
            IndexViewModel IndexVM = new IndexViewModel()
            {
                Categories = await db.Categories.ToListAsync(),
                Posts = await db.Posts.Include(m => m.Category).Include(m => m.SubCategory)
                .Where(m=>m.Status == SD.PostApproved && m.IsFounded == false).ToListAsync()

        };
            return View(IndexVM);
        }
         [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = db.Posts.Include(m => m.Category).Include(m => m.SubCategory).SingleOrDefault(m => m.PostId == id);

            if (post == null)
            {
                return NotFound();
            }

            PostVM.Post = post;
            PostVM.subCategoriesList = await db.SubCategories.Where(m => m.CategoryId == PostVM.Post.CategoryId).ToListAsync();

            return View(PostVM);
        }

public async Task<IActionResult> AddComment(Comment comment)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string UserId = claim.Value;
            comment.CreationTime = DateTime.Now;
            comment.Name = UserId;
            db.Comments.Add(comment);
            db.SaveChanges();

            return View(PostVM);
        }
       
    }
}
