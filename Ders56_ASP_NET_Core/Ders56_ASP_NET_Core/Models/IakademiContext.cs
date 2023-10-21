﻿using System;
using Microsoft.EntityFrameworkCore;

namespace Ders56_ASP_NET_Core.Models
{
	public class IakademiContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:iakademiConnection"]);
        }

        public DbSet<Products> Products { get; set;}
    }
}

