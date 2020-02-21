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
            HasKey(a => a.CategoryID);
            //TODO: KALINAN YER
            //HasMany(a=>a.)
        }

    }
}
