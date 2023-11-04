﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iakademi38_proje.Models
{
    public class Category
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        public int ParentID { get; set; }

        [StringLength(50, ErrorMessage = "En fazla 50 Karakter")]
        [Required(ErrorMessage = "Kategori Adı Zorunlu Alan")]
        [DisplayName("Kategori Adi")]
        public string? CategoryName { get; set; }

    }
}
