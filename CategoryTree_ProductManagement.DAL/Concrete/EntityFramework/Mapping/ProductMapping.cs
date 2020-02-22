using CategoryTree_ProductManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.DAL.Concrete.EntityFramework.Mapping
{
    public class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            //EF otomatik tanır bu isimdeki property'yi Primary olarak ben yine de ekliyorum.
            HasKey(a => a.ProductID);

            Property(a => a.ProductName)
               .IsRequired()
               .HasMaxLength(50);

            HasRequired(a => a.UserWhoAdd)
                .WithMany(a => a.Products)
                .HasForeignKey(a => a.UserWhoAddID)
                .WillCascadeOnDelete(false);


        }
    }
}
