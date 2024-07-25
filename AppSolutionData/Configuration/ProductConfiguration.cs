using AppSolutionData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Configuration
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.ToTable("Products");
			builder.HasKey(s=>s.Id);
			builder.Property(s => s.Prices).IsRequired();
			builder.Property(s => s.Stock).IsRequired().HasDefaultValue(0);
			builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
		}
	}
}
