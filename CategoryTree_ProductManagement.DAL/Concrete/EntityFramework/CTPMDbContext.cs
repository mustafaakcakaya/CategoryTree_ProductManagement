using CategoryTree_ProductManagement.DAL.Concrete.EntityFramework.Mapping;
using CategoryTree_ProductManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.DAL.Concrete.EntityFramework
{
    public class CTPMDbContext : DbContext
    {
        public CTPMDbContext() :base ("CTPM")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Error> Errors { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //daha clean code olsun diye Mapping'ler yazarak burada kullandım.
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new ErrorMapping());


            #region PRIMARY KEY IDENTITIES
            //modelBuilder.Entity<Product>()
            //        .Property(a => a.ProductID)
            //        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //modelBuilder.Entity<Category>()
            //    .Property(a => a.CategoryID)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //modelBuilder.Entity<Error>()
            //    .Property(a => a.ErrorID)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //modelBuilder.Entity<User>()
            //    .Property(a => a.UserID)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); 
            #endregion

            //tabloların çoğul(Plural) isime dönüşmesini istemediğimden kullandım.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
