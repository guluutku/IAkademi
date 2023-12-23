using System;
namespace iakademi38_proje.Models
{
	public class MainPageModel
	{

		public List<Product>? SliderProducts { get; set; } // statusID = 1
		public List<Product>? NewProducts { get; set; } // orderByDesending AddDate
		public List<Product>? SpecialProducts { get; set; } // statusID = 2
		public List<Product>? StarredProducts { get; set; }
		public List<Product>? OpportunityProducts { get; set; }
		public List<Product>? NoticeProducts { get; set; }

        public List<Product>? DiscountedProducts { get; set; } // indirimli ürünler- orderByDescending Discount

        public Product? ProductOfDay { get; set; } // statusID = 6

	}
}

