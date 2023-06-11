﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCABPagaloTodoMS.Application.Responses
{
	public class OneUserResponse
	{
		public string? Dni { get; set; }
		public string? Name { get; set; }
		public string? Lastname { get; set; }
		public string? Username { get; set; }
		public string? Email { get; set; }
		public string? PhoneNumber { get; set; }
		public bool? Status { get; set; }
	}
}
