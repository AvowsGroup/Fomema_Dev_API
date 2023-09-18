using Fomema.Model.common;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Fomema.Utility
{
	public static class FileUpload
	{
		public static fileUploadResponse UploadFile(IFormFile file, string fileUploadPath, bool IsGuidName = false)
		{
			bool isUploaded = false;
			string uploadedFileName = string.Empty;
			string originalFileName = string.Empty;

			try
			{
				originalFileName = file.FileName;
				if (IsGuidName)
				{
					Guid guid = Guid.NewGuid();
					var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
					uploadedFileName = guid + extension;
				}
				else
					uploadedFileName = originalFileName;

				var pathBuilt = Path.Combine(Directory.GetCurrentDirectory(), fileUploadPath);
				if (!Directory.Exists(pathBuilt))
				{
					Directory.CreateDirectory(pathBuilt);
				}
				var path = Path.Combine(pathBuilt, uploadedFileName);

				using (var stream = new FileStream(path, FileMode.Create))
				{
					file.CopyTo(stream);
				}
				isUploaded = true;
			}
			catch (Exception ex)
			{
			}

			return new fileUploadResponse
			{
				isUploaded = isUploaded,
				originalFileName = originalFileName,
				uploadedFileName = uploadedFileName
			};
		}

		public static string GetFileUrl(string path, string fileName)
		{
			return fileName != null ? (path.Replace("\\", "/") + "/" + fileName) : "";
		}
		public static string GetFilePathFormat(string path)
		{
			return path.Replace("/", "\\");
		}
		public class FileUploadPath
		{
			public static string formatphoto { get { return "Uploads\\empphoto"; } }
			public static string formattimesheet { get { return "Uploads\\timesheet"; } }

		}
	}
}
