using System;
using Microsoft.CodeAnalysis.Differencing;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using XAct;
using Microsoft.Data.SqlClient;

namespace iakademi38_proje.Models
{
    public class Cls_Product
    {
        iakademi38Context context = new iakademi38Context();

        int subpageCount = 0;

        // kapsülleme
        private string _isim { get; set; }
        public string isim {
            get { return _isim; }
            set { _isim = value; }
        }

        public string? ProductName { get; set; }
        public string? PhotoPath { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }

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

        public List<Product> ProductSelect(string mainPageName, int mainPageCount, string subPageName, int pageNumber)
        {
            List<Product> products;

            subpageCount = context.Settings.FirstOrDefault(s => s.SettingID == 1)!.SubpageCount;

            switch (mainPageName)
            {
                // returns null list
                default:
                    products = context.Products.ToList();
                    break;

                case "Slider":
                    products = context.Products.Where(p => p.StatusID == 1 && p.Active == true).Take(mainPageCount).ToList();
                    break;

                case "New":
                    if (subPageName == "Ana")
                    {
                        // Home/index = ana sayfa
                        products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.AddDate).Take(mainPageCount).ToList();
                    }
                    else
                    {
                        // alt sayfa
                        if (pageNumber == 0)
                        {
                            // alt sayfa ilk tıklanış
                            products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.AddDate).Take(subpageCount).ToList();
                        }
                        else
                        {
                            // ajax = daha fazla ürün getir
                            products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.AddDate).Skip(pageNumber * subpageCount).Take(subpageCount).ToList();
                        }
                    }
                    break;

                case "Special":
                    if (subPageName == "Ana")
                    {
                        products = context.Products.Where(p => p.StatusID == 2 && p.Active == true).Take(mainPageCount).ToList();
                    }
                    else
                    {
                        // alt sayfa
                        if (pageNumber == 0)
                        {
                            products = context.Products.Where(p => p.StatusID == 2 && p.Active == true).Take(subpageCount).ToList();
                        }
                        else
                        {
                            // ajax = daha fazla ürün getir
                            products = context.Products.Where(p => p.StatusID == 2 && p.Active == true).Skip(pageNumber * subpageCount).Take(subpageCount).ToList();
                        }
                    }
                    break;

                case "Discounted":
                    if (subPageName == "Ana")
                    {
                        products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.Discount).Take(mainPageCount).ToList();
                    }
                    else
                    {
                        // alt sayfa
                        if (pageNumber == 0)
                        {
                            products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.Discount).Take(subpageCount).ToList();
                        }
                        else
                        {
                            // ajax = daha fazla ürün getir
                            products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.Discount).Skip(pageNumber * subpageCount).Take(subpageCount).ToList();
                        }
                    }
                    break;

                case "Highlighted":
                    if (subPageName == "Ana")
                    {
                        products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.HighLighted).Take(mainPageCount).ToList();
                    }
                    else
                    {
                        // alt sayfa
                        if (pageNumber == 0)
                        {
                            products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.HighLighted).Take(subpageCount).ToList();
                        }
                        else
                        {
                            // ajax = daha fazla ürün getir
                            products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.HighLighted).Skip(pageNumber * subpageCount).Take(subpageCount).ToList();
                        }
                    }
                    break;

                case "Topseller":
                    if (subPageName == "Ana")
                    {
                        products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.TopSeller).Take(mainPageCount).ToList();
                    }
                    else
                    {
                        // alt sayfa
                        if (pageNumber == 0)
                        {
                            products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.TopSeller).Take(subpageCount).ToList();
                        }
                        else
                        {
                            // ajax = daha fazla ürün getir
                            products = context.Products.Where(p => p.Active == true).OrderByDescending(p => p.TopSeller).Skip(pageNumber * subpageCount).Take(subpageCount).ToList();
                        }
                    }
                    break;

                case "Starred":
                    products = context.Products.Where(p => p.StatusID == 3 && p.Active == true).Take(mainPageCount).OrderBy(p => p.ProductName).ToList();
                    break;

                case "Featured":
                    products = context.Products.Where(p => p.StatusID == 4 && p.Active == true).Take(mainPageCount).ToList();
                    break;

                case "Notable":
                    products = context.Products.Where(p => p.StatusID == 5 && p.Active == true).Take(mainPageCount).OrderBy(p => p.ProductName).ToList();
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
            return product!;
        }

        public Product ProductDetails(string mainPgeName)
        {
            Product? product = context.Products.FirstOrDefault(p => p.StatusID == 6);
            return product!;
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
            using (iakademi38Context context = new iakademi38Context())
            {
                Product? product = context.Products.FirstOrDefault(p => p.ProductID == id);
                product!.HighLighted += 1;
                context.Update(product);
                context.SaveChanges();
            }
        }

        public List<Product> ProductSelectWithCategoryID(int id)
        {
            List<Product> products = new List<Product>();

            products = context.Products.Where(p => p.CategoryID == id).ToList();

            return products;
        }

        public List<Product> ProductSelectWithSupplierID(int id)
        {
            List<Product> products = new List<Product>();

            products = context.Products.Where(p => p.SupplierID == id).ToList();

            return products;
        }

        public List<Cls_Product> SelectProductsByDetails(string query)
        {
            List<Cls_Product> products = new List<Cls_Product>();
            SqlConnection sqlConnection = Connection.ServerConnect;
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Cls_Product product = new Cls_Product();
                product.ProductID = Convert.ToInt32(sqlDataReader["ProductID"]);
                product.ProductName = sqlDataReader["ProductName"].ToString();
                product.UnitPrice = Convert.ToDecimal(sqlDataReader["UnitPrice"]);
                product.PhotoPath = sqlDataReader["PhotoPath"].ToString();
                products.Add(product);

            }

            return products;
        }

        public static List<sp_arama> gettingSearchProducts(string id)
        {
            using(iakademi38Context context = new iakademi38Context())
            {
                var products = context.sp_arama.FromSql($"sp_arama {id}").ToList();
                return products;
            }
        }

    }
}
