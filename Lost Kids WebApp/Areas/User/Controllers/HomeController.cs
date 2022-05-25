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
using Lost_Kids_WebApp.Models.Comments;
using Microsoft.AspNetCore.Identity;

namespace Lost_Kids_WebApp.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;

        [BindProperty]
        public PostViewModel PostVM { get; set; }
        public HomeController(ApplicationDbContext db,UserManager <ApplicationUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
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

       [HttpPost]
        public async Task <IActionResult> Comment(CommentViewModel vm)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);

            if (!ModelState.IsValid)
            {
                return View(PostVM);
            }

            var post = db.Posts.Include(m => m.Category)
                .Include(m => m.SubCategory)
                .Include(m =>m.MainComments)
                .ThenInclude(m=>m.SubComments)
                .SingleOrDefault(m => m.PostId == vm.PostId);

            if (vm.MainCommentId == 0)
            {
                post.MainComments = post.MainComments ?? new List<MainComment>();

                post.MainComments.Add(new MainComment
                {
                    Message = vm.Messsage,
                    Created = DateTime.Now,
                    UserName = user.Name
                });

                db.Posts.Update(post);
            }


            else
            {
                var comment = new SubComment
                {
                    MainCommentId = vm.MainCommentId,
                    Message = vm.Messsage,
                    Created = DateTime.Now,
                };
                await db.SubComments.AddAsync(comment);
            }

            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

    }
}
