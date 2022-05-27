using Lost_Kids_WebApp.Data;
using Lost_Kids_WebApp.Models;
using Lost_Kids_WebApp.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Lost_Kids_WebApp.Areas.User.Controllers
{
    


    [Area("User")]
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IWebHostEnvironment webHostEnvironment;

        [BindProperty]
        public PostViewModel PostVM { get; set; }
        public PostsController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            this.db = db;
            this.webHostEnvironment = webHostEnvironment;
            PostVM = new PostViewModel()
            {
                Post = new Post(),
                categoriesList= db.Categories.ToList(),
            };
        }
        private int pageSize = 2;
        [HttpGet]
        public async Task <IActionResult> Index(int pagenumber=1)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string UserId = claim.Value;
            UserPostsPagingViewModel userPostsPagingVM = new UserPostsPagingViewModel()
            {
                Posts = await db.Posts.Include(m => m.Category).Include(m => m.SubCategory).Where(m => m.AuthorId == UserId).ToListAsync()
            };
            var count = userPostsPagingVM.Posts.Count;
            userPostsPagingVM.Posts = userPostsPagingVM.Posts.OrderByDescending(o => o.PostId)
                .Skip((pagenumber - 1) * pageSize).Take(pageSize).ToList();
            userPostsPagingVM.PagingInfo = new PagingInfo()
            {
                CurrentPage = pagenumber,
                RecordsPerPage = pageSize,
                TotalRecords = count,
                UrlParam = "/User/Posts/Index?pagenumber=:"
            };
            return View(userPostsPagingVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
           
            

            return View(PostVM);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        [ActionName("Create")]
        public async Task<IActionResult> CreatePost()
        {

            if (ModelState.IsValid)
            {
                string ImagePath = @"\Images\download.png";
                var files = HttpContext.Request.Form.Files;

                if (files.Count > 0)
                {
                    
                    string WebRootPath = webHostEnvironment.WebRootPath;
                    string ImageName = DateTime.Now.ToFileTime().ToString() + Path.GetExtension(files[0].FileName);
                    FileStream fileStream = new FileStream(Path.Combine(WebRootPath,"Images",ImageName), FileMode.Create);
                    files[0].CopyTo(fileStream);
                    ImagePath = @"\Images\" + ImageName;

                }
                byte[] image;
                using (var ms = new MemoryStream())
                {
                    files[0].CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    image = fileBytes;
                }

                PostVM.Post.Image = ImagePath;
                db.Posts.Add(PostVM.Post);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(PostVM);
        }
        
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var post = db.Posts.Include(m => m.Category).Include(m=>m.SubCategory).SingleOrDefault(m=>m.PostId == id) ;
            
            if(post == null)
            {
                return NotFound();
            }
            
            PostVM.Post = post;
            PostVM.subCategoriesList = await db.SubCategories.Where(m => m.CategoryId == PostVM.Post.CategoryId).ToListAsync();

            return View(PostVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public async Task<IActionResult> EditPost()
        {
            
                // new uploaded images of the created post will be saved into this static file
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    string webroot = webHostEnvironment.WebRootPath;

                    // change the name of images uploaded to avoid duplicate names so every uploaded image
                    // will take the name of the date of its uploading
                    string ImageName = DateTime.Now.ToFileTime().ToString() + Path.GetExtension(files[0].FileName);

                    FileStream fileStream = new FileStream(Path.Combine(webroot, "Images", ImageName), FileMode.Create);
                    files[0].CopyTo(fileStream);

                  string  ImagePath = @"\Images\" + ImageName;
                    PostVM.Post.Image = ImagePath;

                }

            
                db.Posts.Update(PostVM.Post);
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

        public async Task<IActionResult> GetPostStatus(int id)
        {
            Post post =await db.Posts.FindAsync(id);
            return PartialView("_PostStatus", post.Status);
        }




    }
}
