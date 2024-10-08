using Microsoft.VisualBasic;
using Restaurant_App.ViewModels.Abouts;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Restaurant_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Restaurant_App.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Information> Informations { get; set; }
        public DbSet<About> Abouts { get; set; }
  


    }
}
