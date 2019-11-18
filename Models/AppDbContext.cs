using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadphonesStore.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Audio> Headphones { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "In-Ear" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "On-Ear" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Overhead" });

            modelBuilder.Entity<Audio>().HasData(new Audio
            {
                HeadphonesId = 1,
                Name = "Sennheiser HD559",
                Price = 123.4M,
                Description = "Over head phones",
                CategoryId = 3,
                ImageUrl = "https://assets.sennheiser.com/img/18209/product_detail_x2_desktop_HD_559_Sennheiser_01.jpg",
                InStock = true,
                PopularHeadphones = true,
                ImageHumbnailUrl = "https://i.imgur.com/axatiZR.jpg"
            });
            modelBuilder.Entity<Audio>().HasData(new Audio
            {
                HeadphonesId = 2,
                Name = "Sony WF-1000XM3",
                Price = 63.4M,
                Description = "",
                CategoryId = 1,
                ImageUrl = "https://www.sony.ro/image/888927839ebfd97a069947fff3642c85?fmt=png-alpha&wid=720",
                InStock = true,
                PopularHeadphones = true,
                ImageHumbnailUrl = "https://www.sony.ro/image/53d5d860b293bac0afad1a5181e6e02a?fmt=pjpeg&wid=165&bgcolor=FFFFFF&bgc=FFFFFF"
            });
            modelBuilder.Entity<Audio>().HasData(new Audio
            {
                HeadphonesId = 3,
                Name = "JBL Tune 500 BT",
                Price = 34.4M,
                Description = "",
                CategoryId = 2,
                ImageUrl = "https://s12emagst.akamaized.net/products/17615/17614584/images/res_51d859e1a2a77e187ecd0a45f6b680c6_450x450_b05e.jpg",
                InStock = true,
                PopularHeadphones = true,
                ImageHumbnailUrl = "https://s12emagst.akamaized.net/products/17615/17614584/images/res_51d859e1a2a77e187ecd0a45f6b680c6_80x80_rah.jpg"
            });
        }
    }
}
