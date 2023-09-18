using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Model.timesheet
{
	public class fileuploaddto
	{
		public int Id { get; set; }
		public string description { get; set; }
		public string guidfilename { get; set; }
		public int? timesheet_id { get; set; }
		public IFormFile formattach { get; set; }
		public DateTime? created_date { get; set; }
	}
}
