using CategoryTree_ProductManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.DAL.Concrete.EntityFramework.Mapping
{
    public class CategoryMapping:EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            //zaten keyi olduğunu Class adının yanına ID yazınca EF anlar. ben yine de gözüksün diye ekliyorum.
            //NOTE: sadece ID yazınca da property name'i yine Primary Key olarak algılar EF.
            HasKey(a => a.CategoryID);

            Property(a => a.CategoryName)
                .IsRequired()
                .HasMaxLength(50);

            HasRequired(a => a.UserWhoAdd)
                .WithMany(a => a.Categories)
                .HasForeignKey(a => a.UserWhoAddID);
            
            
            HasMany(p => p.Products)
                .WithMany(c => c.Categories)
                .Map(cp =>
                       {
                           cp.MapLeftKey("ProductID");
                           cp.MapRightKey("CategoryID");
                           cp.ToTable("ProductCategories");
                       });

            HasOptional(a => a.ParentCategory)
                .WithMany(a => a.ChildCategories)
                .HasForeignKey(a => a.ParentCategoryID);
                

        }

    }
}
