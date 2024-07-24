﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSolutionData.Entities
{
	public class User
	{
		public int ID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string PhoneNumber { get; set; }
		public string Email {  get; set; }
		// Ngày sinh 
		public DateTime DOB { get; set; }
		public string FullName { get; set; }
		public DateTime LastLoginDate { get; set; }

	}
}
