using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Entities
{
	public class CategoriesTransaction
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string? Name {  get; set; }
		public string? SeoDescription { get; set; }
		public string? SeoTitle { get; set; }
		public int LanguageId { get; set; }
		public string? SEOAlias { get; set; }
	}
}
