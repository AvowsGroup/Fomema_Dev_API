using Fomema.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fomema_HR.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class common : ControllerBase
	{
        [HttpGet]
        [Route("download")]
        public async Task<IActionResult> Download(string fileUrl)
        {
            if (!string.IsNullOrEmpty(fileUrl))
                fileUrl = FileUpload.GetFilePathFormat(fileUrl);

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), fileUrl);
            if (!System.IO.File.Exists(filePath))
                return NotFound();
            var memory = new MemoryStream();
            await using (var stream = new FileStream(filePath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(filePath), filePath);
        }
        private string GetContentType(string path)
        {
            var provider = new FileExtensionContentTypeProvider();
            string contentType;

            if (!provider.TryGetContentType(path, out contentType))
            {
                contentType = "application/octet-stream";
            }
            if (!provider.TryGetContentType(path, out contentType))
            {
                contentType = "application/pdf";
            }

            return contentType;
        }
    }
}
