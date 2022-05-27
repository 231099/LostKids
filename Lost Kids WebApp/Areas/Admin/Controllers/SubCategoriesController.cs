using Lost_Kids_WebApp.Data;
using Lost_Kids_WebApp.Models;
using Lost_Kids_WebApp.Models.ViewModels;
using Lost_Kids_WebApp.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Areas.Admin.Controllers
{
    //[Authorize(Roles = SD.AdminUser)]
    //[Authorize(Roles = SD.EndUser)]

    [Area("Admin")]


    public class SubCategoriesController : Controller
    {
        private readonly ApplicationDbContext db;

        [TempData]
        public string StatusMessage { get; set; }

        

        public SubCategoriesController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // Index method for displaying the list of subcategories and the category it is related to.

        private int pageSize = 5;

        [HttpGet]
        public async Task<IActionResult> Index(int pagenumber=1)
        {
            SubCategoryPagingViewModel subCategoryPagingVM = new SubCategoryPagingViewModel()
            {
                subCategories = await db.SubCategories.Include(m => m.Category).ToListAsync()
            };

            var count = subCategoryPagingVM.subCategories.Count;
            subCategoryPagingVM.subCategories = subCategoryPagingVM.subCategories.OrderByDescending(o => o.Id)
                .Skip((pagenumber - 1) * pageSize).Take(pageSize).ToList();
            subCategoryPagingVM.PagingInfo = new PagingInfo()
            {
                CurrentPage = pagenumber,
                RecordsPerPage = pageSize,
                TotalRecords = count,
                UrlParam = "/Admin/SubCategories/Index?pagenumber=:"
            };
            return View(subCategoryPagingVM);

        }


        // Get method for creating new subcategory
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
            {
                CategoriesList = await db.Categories.ToListAsync(),
                SubCategory = new Models.SubCategory()
            };
            return View(model);
        }
        //Post method for creating new subcategory
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubCategoryAndCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                // variable to check existing subcategory
                var doesExistSubCategory = await db.SubCategories.Include(m => m.Category)
                    .Where(m => m.CategoryId == model.SubCategory.CategoryId && m.Name == model.SubCategory.Name).ToListAsync();
                if (doesExistSubCategory.Count() > 0)
                {
                    StatusMessage = "Error: This Sub-Category Already Exists Under" + " " + doesExistSubCategory.FirstOrDefault().Category.Name + " " + "Category";
                }
                else
                {
                    db.SubCategories.Add(model.SubCategory);
                    await db.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }

            }

            SubCategoryAndCategoryViewModel modelVM = new SubCategoryAndCategoryViewModel()
            {
                CategoriesList = await db.Categories.ToListAsync(),
                SubCategory = model.SubCategory,
                StatusMessage = StatusMessage
            };
            return View(modelVM);
        }

        // this method to display existing subcategories under the chosen category
        [HttpGet]
      
        public async Task<IActionResult> GetSubCategories(int id)
        {
            List<SubCategory> subCategories = new List<SubCategory>();
            subCategories = await db.SubCategories.Where(m => m.CategoryId == id).ToListAsync();
            return Json(new SelectList(subCategories, "Id", "Name"));
        }

        // Get method for editing subcategory
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var subCategory = await db.SubCategories.FindAsync(id);
            if (subCategory == null)
            {
                return NotFound();
            }



            SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
            {
                CategoriesList = await db.Categories.ToListAsync(),
                SubCategory = subCategory
            };
            return View(model);
        }

        //Post method for editing new subcategory
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Edit(SubCategoryAndCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                // variable to check existing subcategory
                var doesExistSubCategory = await db.SubCategories.Include(m => m.Category)
                    .Where(m => m.CategoryId == model.SubCategory.CategoryId && m.Name == model.SubCategory.Name
                    && m.Id != model.SubCategory.Id).ToListAsync();
                if (doesExistSubCategory.Count() > 0)
                {
                    StatusMessage = "Error: This Sub-Category Already Exists Under" + " " + doesExistSubCategory.FirstOrDefault().Category.Name + " " + "Category";
                }
                else
                {
                    db.SubCategories.Update(model.SubCategory);
                    await db.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                 
            }

            SubCategoryAndCategoryViewModel modelVM = new SubCategoryAndCategoryViewModel()
            {
                CategoriesList = await db.Categories.ToListAsync(),
                SubCategory = model.SubCategory,
                StatusMessage = StatusMessage
            };
            return View(modelVM);
        }

        // Get method for deleting subcategory
        [HttpGet]
        public  IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var subCategory =  db.SubCategories.Include(m=>m.Category).Where(m=>m.Id == id).SingleOrDefault();
            if (subCategory == null)
            {
                return NotFound();
            }




            return View(subCategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(SubCategory subCategory)
        {

            db.SubCategories.Remove(subCategory);
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
             
        }

        // Get method for displaying details of subcategory
        [HttpGet]
        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var subCategory = db.SubCategories.Include(m => m.Category).Where(m => m.Id == id).SingleOrDefault();
            if (subCategory == null)
            {
                return NotFound();
            }




            return View(subCategory);
        }
    }

}

