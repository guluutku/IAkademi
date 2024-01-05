using System;
namespace iakademi38_proje.Models
{
	public class MainPageModel
	{

		public List<Product>? SliderProducts { get; set; } // statusID = 1
		public List<Product>? NewProducts { get; set; } // orderByDesending AddDate
		public List<Product>? SpecialProducts { get; set; } // statusID = 2
		public List<Product>? StarredProducts { get; set; } // statusID = 3
        public List<Product>? FeaturedProducts { get; set; } // statusID = 4
        public List<Product>? NotableProducts { get; set; } // statusID = 5

        public List<Product>? DiscountedProducts { get; set; } // indirimli ürünler- orderByDescending Discount
        public List<Product>? HighlightedProducts { get; set; } // OrderByDescending Highlighted
        public List<Product>? TopSelledProducts { get; set; } // OrderByDescending Topseller

        public Product? ProductOfDay { get; set; } // statusID = 6

		// Ürün detayları sayfası
		// Product details page
		public Product? ProductDetails { get; set; }
		public string? CategoryName { get; set; }
		public string? BrandName { get; set; }
		public List<Product>? RelatedProducts { get; set; }

	}
}

