using CategoryTree_ProductManagement.Core.DataAccess.EntityFramework;
using CategoryTree_ProductManagement.DAL.Abstract;
using CategoryTree_ProductManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.DAL.Concrete.EntityFramework.DAL
{
    class ErrorDAL : EFRepositoryBase<Error, CTPMDbContext>, IErrorDAL
    {

    }
}
