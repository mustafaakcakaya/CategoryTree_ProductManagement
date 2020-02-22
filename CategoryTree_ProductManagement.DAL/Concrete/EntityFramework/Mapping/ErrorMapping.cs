using CategoryTree_ProductManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.DAL.Concrete.EntityFramework.Mapping
{
    class ErrorMapping : EntityTypeConfiguration<Error>
    {
        public ErrorMapping()
        {
            HasKey(a => a.ErrorID);

            Property(a => a.Description)
                .IsOptional()
                .HasMaxLength(500);

        }
    }
}
