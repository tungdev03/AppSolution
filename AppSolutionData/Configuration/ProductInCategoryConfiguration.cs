using AppSolutionData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Configuration
{
	internal class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
	{
		public void Configure(EntityTypeBuilder<ProductInCategory> builder)
		{
			builder.HasKey(t => new
			{
				t.ProductId, t.CategoryId
			});
			builder.ToTable("ProductInCategories");
			builder.HasOne(t=> t.Product).WithMany(p=>p.ProductInCategories).HasForeignKey(t => t.ProductId);
			builder.HasOne(t => t.Category).WithMany(p => p.ProductInCategories).HasForeignKey(t => t.CategoryId);
		}
	}
}
