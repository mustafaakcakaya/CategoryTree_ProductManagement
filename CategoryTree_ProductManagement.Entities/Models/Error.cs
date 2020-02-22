using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.Entities.Models
{
    public class Error
    {
        public int ErrorID { get; set; }
        public string Description { get; set; }
        public int ErrorOwnerID { get; set; }

        public User ErrorOwner { get; set; }

    }
}
