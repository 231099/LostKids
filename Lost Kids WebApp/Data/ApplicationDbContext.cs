using Lost_Kids_WebApp.Models;
using Lost_Kids_WebApp.Models.Comments;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lost_Kids_WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }
        public DbSet <Category> Categories { get; set; }
        public DbSet <SubCategory> SubCategories{ get; set; }

        public DbSet <ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<MainComment> MainComments { get; set; }

        public DbSet<SubComment> SubComments { get; set; }

    }
}
