using Fomema.Model.employeeregistration;
using Fomema.Model.timesheet;
using Fomema.Services.interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fomema_HR.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class timesheet : ControllerBase
	{
		private readonly ItimeSheetService _itimeSheetService;
		public timesheet(ItimeSheetService itimeSheetService)
		{
			_itimeSheetService = itimeSheetService;

		}
		[HttpGet]
		[Route("gettimesheetRegistration")]
		public async Task<IActionResult> gettimesheetRegistration()
		{
			var timesheetregistrationDetails = _itimeSheetService.gettimesheetRegistration();
			return Ok(timesheetregistrationDetails);
		}
		[HttpGet]
		[Route("gettimesheetRegistrationListByID")]
		public async Task<IActionResult> gettimesheetRegistrationListByID(int Id)
		{
			var employeeregistrationDetails = _itimeSheetService.gettimesheetRegistrationListByID(Id);
			return Ok(employeeregistrationDetails);
		}
		[HttpPost]
		[Route("savetimesheetRegistration")]
		public async Task<IActionResult> savetimesheetRegistration([FromForm] empRequestUpload requestUpload)
		{
			timesheetRegistrationDto data = JsonConvert.DeserializeObject<timesheetRegistrationDto>(requestUpload.strData.ToString());
			data.formattach = requestUpload.pic;
			var employeeregistrationDetails = _itimeSheetService.savetimesheetRegistration(data);
			return Ok(employeeregistrationDetails);
		}
		[HttpPost]
		[Route("savefileupload")]
		public async Task<IActionResult> savefileupload([FromForm] empRequestUpload requestUpload)
		{
			fileuploaddto data = JsonConvert.DeserializeObject<fileuploaddto>(requestUpload.strData.ToString());
			data.formattach = requestUpload.pic;
			var savefileDetails = _itimeSheetService.savefileupload(data);
			return Ok(savefileDetails);
		}
		[HttpGet]
		[Route("deletefileupload")]
		public async Task<IActionResult> deletefileupload(int Id)
		{
			var savefileDetails = _itimeSheetService.Deletefileuploads(Id);
			return Ok(savefileDetails);
		}
		[HttpGet]
		[Route("FileuploadList")]
		public async Task<IActionResult> FileuploadList(int Id)
		{
			var fileuploadDetails = _itimeSheetService.FileuploadList(Id);
			return Ok(fileuploadDetails);
		}

		// GET: api/<timesheet>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<timesheet>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<timesheet>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<timesheet>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<timesheet>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
