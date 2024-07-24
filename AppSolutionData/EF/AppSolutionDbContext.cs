using AppSolutionData.Configuration;
using AppSolutionData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.EF
{
	public class AppSolutionDbContext : DbContext
	{
		public AppSolutionDbContext(DbContextOptions<AppSolutionDbContext> options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AppConfiguration());
			modelBuilder.ApplyConfiguration(new ProductConfiguration());
			modelBuilder.ApplyConfiguration(new CategoryConfiguration());
			modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
			base.OnModelCreating(modelBuilder);
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }

		public DbSet<Cart> Carts { get; set; }
		public DbSet<CategoriesTransaction> CategoriesTransactions { get; set; }
		public DbSet<AppConfig> AppConfig { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Function> Functions { get; set; }
		public DbSet<Language> Languages { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<Permissions> Permissions { get; set; }
		public DbSet<ProductTranslations> ProductTranslations { get; set; }
		public DbSet<Promotion> Promotions { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<SystemActivity> SystemActivities { get; set; }
		public DbSet<Transaction> Transactions { get; set; }

	}
}
