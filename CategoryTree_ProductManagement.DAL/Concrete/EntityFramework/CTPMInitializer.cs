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
                                    new Product() { ProductID=1, ProductName = "LCD", LastSeenDate=DateTime.Now.AddDays(5), Price = 2500, CreatedDate = DateTime.Now, UserWhoAddID = 1, CoverPicPath ="images/LCD.jpeg"  } 
                                } 
                            },

                            new Category() 
                            { 
                                CategoryID=4,
                                CategoryName = "Telefon",
                                CreatedDate = DateTime.Now,
                                UserWhoAddID=1,
                                ParentCategoryID = 1,
                                CategoryOrder=2
                            }
                        }
                    }
                }
            },
            //ikinci kişi
            new User()
            {
                 UserID = 1,
                 FirstName="Afatsum",
                 LastName="Ayakacka",
                 Email ="rt.ayakacka.m@gmail.com",
                 Password="123.sifre",
                 CellPhone="(534)724 2456",
                 Categories = new List<Category>()
                 {
                     new Category(){
                         CategoryID = 2,
                         CategoryName = "Ev Eşyası",
                         CategoryOrder = 2,
                         CreatedDate = DateTime.Now

                    }
                 }
            }
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
