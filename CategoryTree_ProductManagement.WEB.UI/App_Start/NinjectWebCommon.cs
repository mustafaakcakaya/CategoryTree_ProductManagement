using CategoryTree_ProductManagement.BLL.Abstract.EntityServices;
using CategoryTree_ProductManagement.BLL.Concrete;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CategoryTree_ProductManagement.WEB.UI.App_Start
{
    public class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch 
            {
                kernel.Dispose();
                throw;
            }
        }
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static void RegisterServices(StandardKernel kernel)
        {
            kernel.Bind<ICategoryService>().To<CategoryService>();
            kernel.Bind<IErrorService>().To<ErrorService>();
            kernel.Bind<IProductService>().To<ProductService>();
            kernel.Bind<IUserService>().To<UserService>();

            kernel.Load<CustomDALModule>();
        }
    }
}