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
			base.OnModelCreating(modelBuilder);
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }

	}
}
