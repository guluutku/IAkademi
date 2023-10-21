using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ders56_ASP_NET_Core.Models
{
	public class Products
	{
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Set Primary key
		public int ProductID { get; set;}

		[Required(ErrorMessage = "Ürün Adı Girmak Zorunlu")]
		[MaxLength(40)]
		[MinLength(3)]
		[DisplayName("ÜRÜN ADI")] // Formda görünecek kısım
        public string? ProductName { get; set; }

    }
}

