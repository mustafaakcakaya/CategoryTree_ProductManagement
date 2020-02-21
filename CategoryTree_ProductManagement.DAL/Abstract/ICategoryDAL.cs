using CategoryTree_ProductManagement.Core.DataAccess;
using CategoryTree_ProductManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.DAL.Abstract
{
    public interface ICategoryDAL : IEntityRepository<Category>
    {

    }
}
