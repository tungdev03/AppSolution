using AppSolutionData.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Entities
{
	public class Promotion
	{
		public int Id { get; set; }
		public DateTime Fromdate { get; set; }
		public DateTime ToDate { get; set; }
		public bool ApplyForAll { get; set; }
		public decimal DisscountAmount { get; set; }
		public int ProductIds { get; set; }
		public int ProductcategoryIds { get; set; }
		public Status Status { get; set; }
		public string? Name { get; set; }

	}
}
