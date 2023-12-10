using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iakademi38_proje.Models
{
    public class Product
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int ProductID { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Ürün adı girilmeli")]
        [DisplayName("Ürün Adı")]
        public string? ProductName { get; set; }

        [DisplayName("Birim Fiyatı")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Kategori")]
        public int CategoryID { get; set; }

        [DisplayName("Marka")]
        public int SupplierID { get; set; }

        [DisplayName("Stok")]
        public int Stock { get; set; }

        [DisplayName("İndirim")]
        public int Discount { get; set; }

        [DisplayName("Statüs")]
        public int StatusID { get; set; }

        [DisplayName("Eklenme Tarihi")]
        public DateTime AddDate { get; set; }

        [DisplayName("Anahtar Kelimeler")]
        public string? Keywords { get; set; }

        // encapsulation
        private int _Kdv { get; set; }
        public int Kdv { 
            get { return _Kdv; } 
            set
            {
                _Kdv = Math.Abs(value);
            }
        }

        public int HighLighted { get; set; } // öne çıkanlar
        public int TopSeller { get; set; } // çok satanlar

        [DisplayName("Buna Bakanlar")]
        public int Related { get; set; } // Buna Bakanlar

        [DisplayName("Notelar")]
        public string? Notes { get; set; }

        [DisplayName("Fotoğraf")]
        public string? PhotoPath { get; set; }

        [DisplayName("Aktif/Pasif")]
        public bool Active { get; set; }

    }
}
