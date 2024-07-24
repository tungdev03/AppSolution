using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Entities
{
	public class Product
	{
		public int Id { get; set; }
		public decimal Prices { get; set; }
		public decimal PriginalPrince { get; set; }
		public int Stock { get; set; }
		public int ViewCount { get; set; }
		public DateTime DateCrate { get; set; }
		public string SEOAlias { get; set; }

		public List<ProductInCategory> ProductInCategories { get; set; }
		public List<OrderDetail> OrderDetails { get; set; }
		public List<Cart> Carts { get; set; }

		public List<ProductTranslations> ProductTranslations { get; set; }

		public List<ProductImage> ProductImages { get; set; }
	}
}
