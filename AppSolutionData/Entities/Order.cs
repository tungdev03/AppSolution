using AppSolutionData.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Entities
{
	public class Order
	{
		public int Id { get; set; }
		public DateTime OrderDate { get; set; }
		public int UserId { get; set; }
		public string? ShipName { get; set; }
		public string? ShipAddress { get; set; }
		public string? ShipEmail { get; set; }
		public string? ShipPhoneNumber { get; set; }
		public OrderStatus Status { get; set; }

		public List<OrderDetail> OrderDetails { get; set; }
	}
}
