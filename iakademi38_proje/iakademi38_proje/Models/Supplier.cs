﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iakademi38_proje.Models
{
    public class Supplier
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int SupplierID { get; set; }

        [StringLength(100)]
        [Required]
        [DisplayName("Marka Adı")]
        public string? BrandName { get; set; }

        [DisplayName("Resim")]
        public string? PhotoPath { get; set; }

        [DisplayName("Aktif/Pasif")]
        public bool Active { get; set; }

    }
}
