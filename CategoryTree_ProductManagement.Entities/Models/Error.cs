using CategoryTree_ProductManagement.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.Entities.Models
{
    public class Error:IEntity
    {
        public int ErrorID { get; set; }
        public string Description { get; set; }
        public int ErrorOwnerID { get; set; }

        public DateTime ErrorDate { get; set; }

        public User ErrorOwner { get; set; }

    }
}
