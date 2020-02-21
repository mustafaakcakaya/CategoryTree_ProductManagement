using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.Entities.Models
{
    class User
    {
        public User()
        {
            Products = new HashSet<Product>();
            Categories = new HashSet<Category>();
        }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> Categories { get; set; }


    }
}
