using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iakademi38_proje.Models
{
    public class Product
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Ürün adı girilmeli")]
        public string? ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        [DisplayName("Kategori")]
        public int CategoryID { get; set; }

        [DisplayName("Marka")]
        public int SupplierID { get; set; }

        public int Stock { get; set; }

        public int Discount { get; set; }

        [DisplayName("Statüs")]
        public int StatusID { get; set; }

        public DateTime AddDate { get; set; }

        public string? Keywords { get; set; }

    }
}
