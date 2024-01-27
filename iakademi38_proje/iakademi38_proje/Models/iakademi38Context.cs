﻿using Microsoft.EntityFrameworkCore;

namespace iakademi38_proje.Models
{
    public class iakademi38Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // veri tabanı bağlantı ayarları
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:iakademi38Connection"]);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Message> Messages { get; set; }
        public DbSet<vw_MyOrders> vw_MyOrders { get; set; }
        public DbSet<sp_arama> sp_arama { get; set; }

    }
}
