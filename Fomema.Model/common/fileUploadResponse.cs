using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Model.common
{
	public class fileUploadResponse
	{
		public string uploadedFileName { get; set; }
		public string originalFileName { get; set; }
		public bool isUploaded { get; set; }
	}
}
