﻿using Microsoft.EntityFrameworkCore;
using ShopMaster.Services.ShoppingCardAPI.Models;

namespace ShopMaster.ServicesShoppingCardAPI.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
        }
    }
}
