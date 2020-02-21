using CategoryTree_ProductManagement.DAL.Concrete.EntityFramework.Mapping;
using CategoryTree_ProductManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.DAL.Concrete.EntityFramework
{
    class CTPMDbContext : DbContext
    {
        public CTPMDbContext() :base ("CTPM")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new UserMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}
