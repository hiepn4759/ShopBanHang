using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model.Models;

namespace Shop.Data
{
    public class ShopBanHangDbContext : DbContext
    {
        public ShopBanHangDbContext() : base("ShopBanHangConnection")
        {
            //khi load bang cha thi khong tu dong include bang con
            this.Configuration.LazyLoadingEnabled = false;
        }

        /// <summary>
        /// khoi tao dbset cho entity
        /// </summary>
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        /// <summary>
        /// khoi tao 
        /// </summary>
        /// <returns></returns>
        public static ShopBanHangDbContext Create()
        {
            return new ShopBanHangDbContext();
        }
        
        /// <summary>
        /// chay khi khoi tao entity
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}
