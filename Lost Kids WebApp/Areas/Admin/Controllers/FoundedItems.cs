using Lost_Kids_WebApp.Data;
using Lost_Kids_WebApp.Models;
using Lost_Kids_WebApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FoundedItems : Controller
    {
        private readonly ApplicationDbContext db;
        [BindProperty]
        public PostViewModel PostVM { get; set; }
        public FoundedItems(ApplicationDbContext db)
        {
            this.db = db;
            PostVM = new PostViewModel()
            {
                Post = new Post(),
                categoriesList = db.Categories.ToList()

            };
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string UserId = claim.Value;
            var Posts = await db.Posts.Include(m => m.Category).Include(m => m.SubCategory).Where(m=> m.IsFounded != true).ToListAsync();
            return View(Posts);
        }

        public async Task<IActionResult> IsFound(int id)
        {
            var Post = await db.Posts.FindAsync(id);
            Post.IsFounded = true ;
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
    }
}
