using CategoryTree_ProductManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.DAL.Concrete.EntityFramework.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(a => a.UserID);

            HasMany(a => a.Errors)
                .WithRequired(a => a.ErrorOwner)
                .HasForeignKey(a => a.ErrorOwnerID);


            Property(a => a.FirstName)
                .HasMaxLength(35)
                .IsRequired();

            Property(a => a.LastName)
                .HasMaxLength(35)
                .IsRequired();

            Property(a => a.CellPhone)
                .HasColumnType("char")
                .HasMaxLength(13)
                .IsRequired();
        }
    }
}
