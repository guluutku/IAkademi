using System;
using Microsoft.EntityFrameworkCore;

namespace iakademi38_proje.Models
{
	public class Cls_Category
	{
		iakademi38Context context = new iakademi38Context();
		
		public Cls_Category()
		{
		}

        public static bool CategoryInsert(Category category)
        {
			try
			{
				using(iakademi38Context context = new iakademi38Context())
				{
					context.Add(category);
					context.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
        }

        public async Task<List<Category>> CategorySelect()
		{
			List<Category> categories = await context.Categories.ToListAsync();
			return categories;
		}

		// Ana kategorileri bul
        // List<Category> categories = cls_Category.CategorySelectMain();
		public List<Category> CategorySelectMain()
		{
            List<Category> categories = context.Categories.Where(c => c.ParentID == 0).ToList();
			return categories;
        }

        public async Task<Category> CategoryDetails(int? id)
        {
            Category? category = await context.Categories.FindAsync(id);
			return category;
        }

        public static bool CategoryUpdate(Category category)
        {
			try
			{
				using (iakademi38Context context = new iakademi38Context())
				{
					context.Update(category);
					context.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
        }

        public static bool CategoryDelete(int id)
        {
			try
			{
				using(iakademi38Context context = new iakademi38Context())
				{
					Category category = (Category)context.Categories.Where(c => c.CategoryID == id);
					category.isActive = false;

					List<Category> categorylist = context.Categories.Where(c => c.ParentID == id).ToList();

					foreach(var item in categorylist)
					{
						item.isActive = false;
					}

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

