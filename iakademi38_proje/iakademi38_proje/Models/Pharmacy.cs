﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iakademi38_proje.Models
{
    public class Pharmacy
    {

        public DateTime Tarih { get; set; }
        public string? LokasyonY { get; set; }
        public string? LokasyonX { get; set; }
        public string? Adi { get; set; }
        public string? Telefon { get; set; }
        public string? Adres { get; set; }

    }
}
