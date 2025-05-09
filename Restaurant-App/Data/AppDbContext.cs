﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Restaurant_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Restaurant_App.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category>Categories { get; set; }

    }
}
