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

		public async Task<List<Category>> CategorySelect()
		{
			List<Category> categories = await context.Categories.ToListAsync();
			return categories;
		}

	}
}

