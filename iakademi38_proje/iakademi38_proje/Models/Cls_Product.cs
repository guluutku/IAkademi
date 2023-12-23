﻿using System;
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
            switch (mainPageName)
            {
                // returns null list
                default:
                    List<Product> products = context.Products.Where(p => p.StatusID == 0 && p.Active == true).ToList();
                    return products;

                case "Slider":
                    List<Product> sliderProducts = context.Products.Where(p => p.StatusID == 1 && p.Active == true).ToList();
                    return sliderProducts;

                case "New":
                    List<Product> newProducts = context.Products.Where(p => p.AddDate == DateTime.Now && p.Active == true).ToList();
                    return newProducts;

                case "Special":
                    List<Product> specialProducts = context.Products.Where(p => p.StatusID == 2 && p.Active == true).ToList();
                    return specialProducts;

                case "Starred":
                    List<Product> starredProducts = context.Products.Where(p => p.StatusID == 3 && p.Active == true).ToList();
                    return starredProducts;

            }
            
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
    }
}