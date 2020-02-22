namespace CategoryTree_ProductManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Concrete.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<CategoryTree_ProductManagement.DAL.Concrete.EntityFramework.CTPMDbContext>
    {
        public Configuration()
        {
            //true'ya çektim ki migration'lar overwrite yapsın.
            //false ile Source Control toolları gibi migration'larla database düzenlenmesi de yapılabilir.
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CTPMDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
