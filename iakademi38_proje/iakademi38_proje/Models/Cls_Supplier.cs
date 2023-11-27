using System;
using Microsoft.EntityFrameworkCore;

namespace iakademi38_proje.Models
{
	public class Cls_Supplier
	{

        iakademi38Context context = new iakademi38Context();
		public Cls_Supplier()
		{
		}

        public async Task<List<Supplier>> SupplierSelect()
        {
            List<Supplier> suppliers = await context.Suppliers.ToListAsync();
            return suppliers;
        }
    }
}

