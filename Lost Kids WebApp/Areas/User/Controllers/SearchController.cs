using GroupDocs.Comparison;
using Lost_Kids_WebApp.Data;
using Lost_Kids_WebApp.Models;
using Lost_Kids_WebApp.Models.ViewModels;
using Lost_Kids_WebApp.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Areas.User.Controllers
{
    [Area("User")]
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext db;
        [BindProperty]
        public PostViewModel PostVM { get; set; }
        public SearchController(ApplicationDbContext db)
        {
            this.db = db;
            PostVM = new PostViewModel()
            {
                Post = new Post(),
                categoriesList = db.Categories.ToList()

            };

        }

        private int pageSize = 2;


        [HttpGet]
        public async Task<IActionResult> Index(string SearchName = null, string SearchPhone = null, 
            string SearchEmail = null,string SearchPhoto= null,int pagenumber=1)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string UserId = claim.Value;

            

            SearchPostPagingViewModel searchPostPagingVM = new SearchPostPagingViewModel()
            {
                Posts = await db.Posts.Include(m => m.Category).Include(m => m.SubCategory)
                .Where(m => m.PhoneNumber.Contains(SearchPhone) || m.AuthorEmail.Contains(SearchEmail)
                || m.AuthorName.Contains(SearchName) || m.Image.Contains(SearchPhoto)).ToListAsync()
            };
            var count = searchPostPagingVM.Posts.Count;
            searchPostPagingVM.Posts = searchPostPagingVM.Posts.OrderByDescending(o => o.PostId)
                .Skip((pagenumber - 1) * pageSize).Take(pageSize).ToList();
            searchPostPagingVM.PagingInfo = new PagingInfo()
            {
                CurrentPage = pagenumber,
                RecordsPerPage = pageSize,
                TotalRecords = count,
                UrlParam = "/User/Search/Index?pagenumber=:"
            };
            StringBuilder param = new StringBuilder();

            param.Append("&SearchName =");
            if (SearchName != null)
            {
                param.Append(SearchName);
            }
            else
            {
                SearchName = " ";
            }
            param.Append("&SearchEmail =");
            if (SearchEmail != null)
            {
                param.Append(SearchEmail);
            }
            else
            {
                SearchEmail = " ";
            }
            param.Append("&SearchPhone =");
            if (SearchPhone != null)
            {
                param.Append(SearchPhone);
            }
            else
            {
                SearchPhone = " ";
            }

            param.Append("&SearchPhone =");
            if (SearchPhone != null)
            {
                param.Append(SearchPhone);
            }
            else
            {
                SearchPhone = " ";
            }

            return View(searchPostPagingVM);
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

        //public async Task<IActionResult> CompareImage()
        //{
           
        //}

    }
}

