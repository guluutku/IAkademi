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
    }
}

