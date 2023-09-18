using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Model.timesheet
{
	public class timesheetRegistrationDto
	{
		public int id { get; set; }
		public DateTime? clock_date { get; set; }
		public string clock_day { get; set; }
		public DateTime? shift_time_in { get; set; }
		public DateTime? shift_time_out { get; set; }
		public DateTime? actual_time_in { get; set; }
		public DateTime? actual_time_out { get; set; }
		public DateTime? actual_ot_hr { get; set; }
		public DateTime? lateness { get; set; }
		public DateTime? early_out { get; set; }
		public DateTime? requested_time_in { get; set; }
		public DateTime? requested_time_out { get; set; }
		public DateTime? requested_ot_hr { get; set; }
		public DateTime? requested_lateness { get; set; }
		public DateTime? requested_earlyout { get; set; }
		public string reason { get; set; }
		public string remarks { get; set; }
		public int? status { get; set; }
		public string statusname { get; set; }
		public IFormFile formattach { get; set; }
		public string empattach { get; set; }
		public string guidempattach { get; set; }
		public int created_by { get; set; }
		public int modified_by { get; set; }
		public DateTime? created_date { get; set; }
		public DateTime? modified_date { get; set; }

	}
}
