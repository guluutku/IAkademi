using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ders56_ASP_NET_Core.Models
{
	public class Products
	{
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Set Primary key and isIdentity
        [DisplayName("ID")]
        public int ProductID { get; set;}

		[Required(ErrorMessage = "Ürün Adı Girmak Zorunlu")]
		[MaxLength(40)]
		[MinLength(3)]
		[DisplayName("ÜRÜN ADI")] // Formda görünecek kısım
		[RegularExpression(@"^[A-Za-z0-9\\s\\-_]{3,40}$")] // Disaable Regular Expressions
        public string? ProductName { get; set; }

        private decimal _UnitPrice { get; set;}
        [Required(ErrorMessage = "Ürün Fiyatı Girmak Zorunlu")]
        [DisplayName("ÜRÜN FİYAT")]
        // Encapsulation
        public decimal UnitPrice
		{
			get { return _UnitPrice;}
			set { _UnitPrice = Math.Abs(value);}
		}
    }
}

