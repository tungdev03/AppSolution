﻿using AppSolutionData.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Entities
{
	public class Contact
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email {  get; set; }
		public string PhoneNumber { get; set; }
		public string Message { get; set; }
		public Status Status { get; set; }

	}
}
