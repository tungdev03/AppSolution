using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Entities
{
	public class ProductTranslations
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? Detail {  get; set; }
		public string? SEODescription { get; set; }
		public string? SEOTitle { get; set; }
		public int LangueId { get; set; }

	}
}
