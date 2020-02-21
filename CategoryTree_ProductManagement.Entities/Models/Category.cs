using CategoryTree_ProductManagement.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.Entities.Models
{
    public class Category:IEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryOrder { get; set; }
        public int UserWhoAddID { get; set; }
        public int? ParentCategoryID { get; set; }


        //NAVIGATION PROPERTIES
        public User UserWhoAdd { get; set; }
        public Category ParentCategory { get; set; }

        public virtual ICollection<Product> Products { get; set; }


    }
}
