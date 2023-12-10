using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iakademi38_proje.Models
{
    public class Status
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int StatusID { get; set; }

        [StringLength(100)]
        [Required]
        [DisplayName("Durum Adı")]
        public string? StatusName { get; set; }

        [DisplayName("Aktif Mi?")]
        public bool Active { get; set; }

    }
}
