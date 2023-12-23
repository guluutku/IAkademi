using System;
namespace iakademi38_proje.Models
{
	public class MainPageModel
	{

		public List<Product>? SliderProducts { get; set; }
		public List<Product>? SpecialProducts { get; set; }
		public List<Product>? StarredProducts { get; set; }
		public Product? ProductOfDay { get; set; }

	}
}

