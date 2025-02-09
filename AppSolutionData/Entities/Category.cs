﻿using AppSolutionData.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Entities
{
	public class Category
	{
		public int  Id {  get; set; }
		public int  SortOrder { get; set; }
		public bool  IsShowOnHome { get; set; }
		public int?  ParentId { get; set; }
		public Status  Status { get; set; }

		public List<ProductInCategory> ProductInCategories { get; set; }

	}
}
