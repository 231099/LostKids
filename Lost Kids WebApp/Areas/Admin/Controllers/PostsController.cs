using Lost_Kids_WebApp.Data;
using Lost_Kids_WebApp.Models;
using Lost_Kids_WebApp.Models.ViewModels;
using Lost_Kids_WebApp.Utility;
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
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext db;

        [BindProperty]
        public PostViewModel PostVM { get; set; }
        public PostsController(ApplicationDbContext db)
        {
            this.db = db;
            PostVM = new PostViewModel()
            {
                Post = new Post(),
                categoriesList = db.Categories.ToList()

            };
        }

        private int pageSize = 3;


        [HttpGet]
        public async Task<IActionResult> Index(int pagenumber =1 )
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string UserId = claim.Value;
            AdminPostsPagingViewModel adminPostsPagingVM = new AdminPostsPagingViewModel()
            {
                Posts = await db.Posts.Include(m => m.Category).Include(m => m.SubCategory).Where(m => m.IsFounded == false).ToListAsync()
        };
            var count = adminPostsPagingVM.Posts.Count;
            adminPostsPagingVM.Posts = adminPostsPagingVM.Posts.OrderByDescending(o => o.PostId)
                .Skip((pagenumber - 1) * pageSize).Take(pageSize).ToList();
            adminPostsPagingVM.PagingInfo = new PagingInfo()
            {
                CurrentPage = pagenumber,
                RecordsPerPage = pageSize,
                TotalRecords = count,
                UrlParam = "/Admin/Posts/Index?pagenumber=:"
            };

            return View(adminPostsPagingVM);
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


        public async Task<IActionResult> SubmitPost(int id)
        {
            var Post = await db.Posts.FindAsync(id);
            Post.Status = SD.PostSubmitted;
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ApprovePost(int id)
        {
            var Post = await db.Posts.FindAsync(id);
            Post.Status = SD.PostApproved;
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
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
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost()
        {




            db.Posts.Remove(PostVM.Post);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }




    }
}
