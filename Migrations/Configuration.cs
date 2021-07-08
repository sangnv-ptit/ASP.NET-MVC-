namespace WebApplication1.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication1.Models.MovieDBContext";
        }

        protected override void Seed(MovieDBContext context)
        {
            try
            {
                //context.Users.AddOrUpdate(x => x.Email,
                //    new Models.User
                //    {
                //        Email = "sang@mail.com",
                //        FirstName = "Sang",
                //        LastName = "Nguyen",
                //        Password = GetMD5("Sang123$5678")
                //    }
                //);
                context.Categories.AddOrUpdate(x => x.Image,
                    new Category
                    {
                        Name = "Áo Phông",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet lacus enim.",
                        Image = "t-shirts-img.jpg",
                        Products = new List<Product>
                        {
                            new Product
                            {
                                Name = "Áo phông xanh",
                                Description = "Lorem ipsum dolor sit amet",
                                Price = 1000000,
                                IsNew = false,
                                IsSale = true,
                                Image = "img-pro-01.jpg"
                            },
                            new Product
                            {
                                Name = "Áo liền váy hoa",
                                Description = "Lorem ipsum dolor sit amet",
                                Price = 1200000,
                                IsNew = true,
                                IsSale = false,
                                Image = "img-pro-02.jpg"
                            }
                        }
                    },
                    new Category
                    {
                        Name = "Áo sơ mi",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet lacus enim.",
                        Image = "shirts-img.jpg"
                    },
                    new Category
                    {
                        Name = "Ví thời trang",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet lacus enim.",
                        Image = "wallet-img.jpg"
                    },
                    new Category
                    {
                        Name = "Túi xách",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet lacus enim.",
                        Image = "women-bag-img.jpg",
                        Products = new List<Product>
                        {
                            new Product
                            {
                                Name = "Túi da xanh nâu",
                                Description = "Lorem ipsum dolor sit amet",
                                Price = 800000,
                                IsNew = false,
                                IsSale = true,
                                Image = "img-pro-03.jpg"
                            }
                        }
                    },
                    new Category
                    {
                        Name = "Giày nam",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet lacus enim.",
                        Image = "shoes-img.jpg",
                        Products = new List<Product>
                        {
                            new Product
                            {
                                Name = "Đồng hồ bạc",
                                Description = "Lorem ipsum dolor sit amet",
                                Price = 500000,
                                IsNew = false,
                                IsSale = true,
                                Image = "img-pro-04.jpg"
                            }
                        }
                    },
                    new Category
                    {
                        Name = "Giày nữ",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet lacus enim.",
                        Image = "women-shoes-img.jpg"
                    }
                );
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }
        private static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
    }
}
