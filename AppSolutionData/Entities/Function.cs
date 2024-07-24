using AppSolutionData.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Entities
{
	public class Function
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int url { get; set; }
		public int ParentId { get; set; }
		public Status Status { get; set; }
		public int SortOrder { get; set; }
	}
}
