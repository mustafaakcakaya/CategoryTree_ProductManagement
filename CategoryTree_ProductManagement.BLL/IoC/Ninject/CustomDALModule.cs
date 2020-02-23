using CategoryTree_ProductManagement.DAL.Abstract;
using CategoryTree_ProductManagement.DAL.Concrete.EntityFramework.DAL;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.BLL.IoC.Ninject
{
    public class CustomDALModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryDAL>().To<CategoryDAL>();
            Bind<IErrorDAL>().To<ErrorDAL>();
            Bind<IUserDAL>().To<UserDAL>();
            Bind<IProductDAL>().To<ProductDAL>();
        }

    }
}
