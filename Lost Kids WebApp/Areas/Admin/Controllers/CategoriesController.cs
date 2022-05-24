using Lost_Kids_WebApp.Data;
using Lost_Kids_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lost_Kids_WebApp.Utility;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Areas.Admin.Controllers
{
    //[Authorize(Roles = SD.AdminUser)]

    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext db;

        public CategoriesController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // index method for displaying the list of categories
        [HttpGet]
        public async Task<IActionResult> Index()
        {

            return View(await db.Categories.ToListAsync());
        }

        // Get Create Method only returns view

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        // post Create Method first create an object from category then add changes to table categories
        // and save changes then return to index method to display the categories list
        // validateAntiForgeryToken is an attribute to prevent accessing to the create method through the url 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(category);
               await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // get edit method first we check if the passed id is empty or not then check the categories list if 
        // the id exist or not 
        [HttpGet]

        public async Task <IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var category = await db.Categories.FindAsync(id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        //Post Edit method for editing Categories
        //edit the name of category then return back to index page to display category's items
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Update(category);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(category);
        }
        [HttpGet]

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await db.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Delete(Category category)
        {
            db.Categories.Remove(category);
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
            var category = await db.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
    }
}