using ComApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComApp.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<TextField> TextFields { get; set; } // Create table this name in DataBase
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //filling data information in DB
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "fb604fa9-8ca3-44d4-a2a7-08bd007264bc",
                Name = "admin",
                NormalizedName = "ADMIN"
            });// Create role Admin

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "28f5c4c9-9dab-4a6e-bbed-c2154ab68d7a",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty,
                
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "fb604fa9-8ca3-44d4-a2a7-08bd007264bc",
                UserId = "28f5c4c9-9dab-4a6e-bbed-c2154ab68d7a"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("80dd1009-80b2-4f68-b5a1-cd6d446ad179"),
                CodeWord = "PageIndex",
                Title = "Home Page"
            });
            
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("c382b28b-4349-4555-8cbd-4184dc7f4470"),
                CodeWord = "PageServices",
                Title = "Services"
            });
            
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("42220e70-d68c-49eb-833c-c5e7634deb31"),
                CodeWord = "PageContacts",
                Title = "Contacts"
            });
        }
    }
}
