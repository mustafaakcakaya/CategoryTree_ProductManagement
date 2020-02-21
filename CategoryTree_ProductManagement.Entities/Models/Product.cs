using CategoryTree_ProductManagement.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.Entities.Models
{
    public class Product:IEntity
    {
        public Product()
        {
            Categories = new HashSet<Category>();
        }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CoverPicPath { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastSeenDate { get; set; }
        public int UserWhoAddID { get; set; }


        public User UserWhoAdd { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

    }
}
