using CategoryTree_ProductManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryTree_ProductManagement.DAL.Concrete.EntityFramework
{
    class CTPMInitializer : CreateDatabaseIfNotExists<CTPMDbContext>
    {
        protected override void Seed(CTPMDbContext context)
        {
            context.Users.AddRange(new List<User>() {
            //birinci kişi
            new User()
            {
                 UserID = 1,
                 FirstName="Mustafa",
                 LastName="Akcakaya",
                 Email ="m.akcakaya.tr@gmail.com",
                 Password="sifre.123",
                 CellPhone="(534)724 2151",//13
                 
                 Categories = new List<Category>(){
                    new Category()
                    {
                        CategoryID = 1,
                        CategoryName = "Elektronik",
                        CategoryOrder = 1,
                        CreatedDate = DateTime.Now,
                        ChildCategories = new List<Category>
                        {
                            new Category()
                            {
                                CategoryID=3,
                                CategoryName = "Televizyon",
                                CreatedDate = DateTime.Now,
                                UserWhoAddID=1,
                                ParentCategoryID = 1,
                                CategoryOrder=1,
                                Products = new List<Product>
                                {
                                    new Product() { ProductID=1, ProductName = "LCD", LastSeenDate=DateTime.Now.AddDays(5), Price = 999, CreatedDate = DateTime.Now, UserWhoAddID = 1, CoverPicPath ="images/LCD.jpeg"  },
                                    new Product() { ProductID=2, ProductName = "Led", LastSeenDate=DateTime.Now.AddDays(7), Price = 1400, CreatedDate = DateTime.Now, UserWhoAddID = 1, CoverPicPath ="images/Led.jpeg"  },
                                    new Product() { ProductID=3, ProductName = "Curved", LastSeenDate=DateTime.Now.AddDays(11), Price = 1750, CreatedDate = DateTime.Now, UserWhoAddID = 1, CoverPicPath ="images/Curved.jpeg"  }
                                }
                            },

                            new Category()
                            {
                                CategoryID=4,
                                CategoryName = "Telefon",
                                CreatedDate = DateTime.Now,
                                UserWhoAddID=1,
                                ParentCategoryID = 1,
                                CategoryOrder=2,
                                ChildCategories = new List<Category>()
                                {
                                    new Category(){ CategoryID=5, CategoryName="Iphone", CreatedDate=DateTime.Now, ParentCategoryID=4, UserWhoAddID=1, CategoryOrder=1, ChildCategories = new List<Category>()
                                        #region Iphone icin alt kategoriler
		{
                                                    new Category(){ CategoryID=6, CategoryName="IPhone 7S", CreatedDate=DateTime.Now, ParentCategoryID=5, CategoryOrder=1, UserWhoAddID=1, ChildCategories = new List<Category>()
                                                    {
                                                        new Category(){CategoryID = 7, ParentCategoryID=6, CategoryName="iphone 7s 32GB", CategoryOrder=1, UserWhoAddID=1, CreatedDate=DateTime.Now, Products = new List<Product>()
                                                        {
                                                        new Product() { ProductID = 4, ProductName="iphone 7s 32GB Siyah", Price=5600, CreatedDate=DateTime.Now, CoverPicPath="images/black7s32.jpeg", LastSeenDate=DateTime.Now.AddDays(5), UserWhoAddID=1 },
                                                        new Product() { ProductID = 5, ProductName="iphone 7s 32GB Beyaz", Price=5600, CreatedDate=DateTime.Now, CoverPicPath="images/white7s32.jpeg", LastSeenDate=DateTime.Now.AddDays(5), UserWhoAddID=1 },
                                                        new Product() { ProductID = 6, ProductName="iphone 7s 32GB Gri", Price=5600, CreatedDate=DateTime.Now, CoverPicPath="images/grey7s32.jpeg", LastSeenDate=DateTime.Now.AddDays(5), UserWhoAddID=1 },
                                                        new Product() { ProductID = 7, ProductName="iphone 7s 32GB Gold", Price=5600, CreatedDate=DateTime.Now, CoverPicPath="images/gold7s32.jpeg", LastSeenDate=DateTime.Now.AddDays(5), UserWhoAddID=1 }

                                                        }},

                                                        new Category(){CategoryID = 8, ParentCategoryID=6, CategoryName="iphone 7s 64GB", CategoryOrder=2, UserWhoAddID=1, CreatedDate=DateTime.Now }
                                                    }},
                                                    new Category(){ CategoryID=9, CategoryName="IPhone X", CreatedDate=DateTime.Now, ParentCategoryID=5, CategoryOrder=2, UserWhoAddID=1 },
                                                    new Category(){ CategoryID=10, CategoryName="IPhone 11", CreatedDate=DateTime.Now, ParentCategoryID=5, CategoryOrder=3, UserWhoAddID=1 }
                                        } 
	                                    #endregion
                                    },

                                    new Category(){ CategoryID=11, CategoryName="Samsung", CreatedDate=DateTime.Now, ParentCategoryID=4, UserWhoAddID=1, CategoryOrder=1, ChildCategories= new List<Category>()
                                    {
                                          new Category(){ CategoryID=9, CategoryName="Note 5", CreatedDate=DateTime.Now, ParentCategoryID=5, CategoryOrder=2, UserWhoAddID=1 },
                                          new Category(){ CategoryID=10, CategoryName="Note 7", CreatedDate=DateTime.Now, ParentCategoryID=5, CategoryOrder=3, UserWhoAddID=1 },
                                          new Category(){ CategoryID=10, CategoryName="Galaxy", CreatedDate=DateTime.Now, ParentCategoryID=5, CategoryOrder=3, UserWhoAddID=1, ChildCategories = new List<Category>()
                                          {
                                            new Category(){ CategoryID=9, CategoryName="Galaxy S6", CreatedDate=DateTime.Now, ParentCategoryID=5, CategoryOrder=2, UserWhoAddID=1 },
                                            new Category(){ CategoryID=9, CategoryName="Galaxt Nexus", CreatedDate=DateTime.Now, ParentCategoryID=5, CategoryOrder=2, UserWhoAddID=1 }
                                          } }
                                    } }

                                }

                            }
                        }
                    }
                }
            },
            //ikinci kişi
            new User()
            {
                 UserID = 2,
                 FirstName="Afatsum",
                 LastName="Ayakacka",
                 Email ="rt.ayakacka.m@gmail.com",
                 Password="123.sifre",
                 CellPhone="(534)724 2456"
            }
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
