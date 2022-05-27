using Lost_Kids_WebApp.Areas.Identity.Pages.Account.Manage;
using Lost_Kids_WebApp.Data;
using Lost_Kids_WebApp.Models;
using Lost_Kids_WebApp.Models.ViewModels;
using Lost_Kids_WebApp.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Areas.Admin.Controllers
{
    [Authorize(Roles =SD.AdminUser)]
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;

        

        public UsersController(ApplicationDbContext db, UserManager<ApplicationUser> _userManager)
        {
            this.db = db;
            this._userManager = _userManager;   
        }

        private int pageSize = 4;

        public async Task <IActionResult> Index(int pagenumber=1)
        {
            /*this method for dipslaying the list of user to the admin but without
            showing admin user which is already logged in*/
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string UserId = claim.Value;
            UserPagingViewModel UserPagingVM = new UserPagingViewModel()
            {
                ApplicationUsers = await db.ApplicationUsers.Where(m => m.Id != UserId).ToListAsync()
            };
            var count = UserPagingVM.ApplicationUsers.Count;
            UserPagingVM.ApplicationUsers = UserPagingVM.ApplicationUsers.OrderByDescending(o => o.Id)
                .Skip((pagenumber - 1) * pageSize).Take(pageSize).ToList();
            UserPagingVM.PagingInfo = new PagingInfo()
            {
                CurrentPage = pagenumber,
                RecordsPerPage = pageSize,
                TotalRecords = count,
                UrlParam = "/Admin/Users/Index?pagenumber=:"
            };

            return View(UserPagingVM);
        }

        // this method for locking & Unlocking User's Account 
        public async Task<IActionResult> LockUnlock(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await db.ApplicationUsers.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            if(user.LockoutEnd == null || user.LockoutEnd < DateTime.Now)
            {
                user.LockoutEnd = DateTime.Now.AddYears(1000);
            }
            else
            {
                user.LockoutEnd = DateTime.Now;
            }

            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult>Delete(String id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await db.ApplicationUsers.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(ApplicationUser user, string userrole)
        {
            if(user==null || userrole == null) {

                return NotFound();
            }

            var removeRole = _userManager.RemoveFromRoleAsync(user, userrole);

            if (removeRole.IsCompletedSuccessfully)
            {
                var removeUser = await _userManager.DeleteAsync(user);

                if (removeUser.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                    return BadRequest("Error User Not Found");
            }

            return RedirectToAction(nameof(Index));
        }

    }



}

