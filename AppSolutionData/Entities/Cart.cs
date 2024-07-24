using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Entities
{
	public class Cart
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal Prince { get; set; }

	}
}
