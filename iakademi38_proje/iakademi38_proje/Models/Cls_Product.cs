using System;
using Microsoft.CodeAnalysis.Differencing;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using XAct;

namespace iakademi38_proje.Models
{
	public class Cls_Product
	{
        iakademi38Context context = new iakademi38Context();

		public Cls_Product()
		{
		}

        public static bool ProductInsert(Product product)
        {
            try
            {
                using (iakademi38Context context = new iakademi38Context())
                {
                    context.Add(product);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Product>> ProductSelect()
        {
            List<Product> products = await context.Products.ToListAsync();
            return products;
        }

        public List<Product> ProductSelect(string mainPageName)
        {
            List<Product> products;

            switch (mainPageName)
            {
                // returns null list
                default:
                    products = context.Products.ToList();
                    break;

                case "Slider":
                    products = context.Products.Where(p => p.StatusID == 1 && p.Active == true).Take(8).ToList();
                    break;

                case "New":
                    products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.AddDate).Take(8).ToList();
                    break;

                case "Special":
                    products = context.Products.Where(p => p.StatusID == 2 && p.Active == true).Take(8).ToList();
                    break;

                case "Discounted":
                    products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.Discount).Take(8).ToList();
                    break;

                 case "Highlighted":
                    products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.HighLighted).Take(8).ToList();
                    break;

                case "Topseller":
                    products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.TopSeller).Take(8).ToList();
                    break;

                case "Starred":
                    products = context.Products.Where(p => p.StatusID == 3 && p.Active == true).Take(8).ToList();
                    break;
                    
                case "Featured":
                    products = context.Products.Where(p => p.StatusID == 4 && p.Active == true).Take(8).ToList();
                    break;

                case "Notable":
                    products = context.Products.Where(p => p.StatusID == 5 && p.Active == true).Take(8).OrderByDescending(p => p.UnitPrice).ToList();
                    break;
            }

            return products;
        }
       
        public static bool ProductUpdate(Product product)
        {
            try
            {
                using (iakademi38Context context = new iakademi38Context())
                {
                    context.Update(product);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Product> ProductDetails(int? id)
        {
            Product? product = await context.Products.FindAsync(id);
            return product;
        }

        public Product ProductDetails(string mainPgeName)
        {
            Product? product = context.Products.FirstOrDefault(p => p.StatusID == 6);
            return product;
        }
        
        public static bool ProductDelete(int id)
        {
            try
            {
                using (iakademi38Context context = new iakademi38Context())
                {
                    Product product = (Product)context.Products.Where(p => p.StatusID == id);
                    product.Active = false;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void Highligted_Increase(int id)
        {
            using(iakademi38Context context = new iakademi38Context())
            {
                Product? product = context.Products.FirstOrDefault(p => p.ProductID == id);
                product!.HighLighted += 1;
                context.Update(product);
                context.SaveChanges();
            }
        }
    }
}
