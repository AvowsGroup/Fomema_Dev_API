using Fomema.Model.employeeregistration;
using Fomema.Services.interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fomema_HR.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class employee : ControllerBase
	{
		private readonly IemployeeService _iemployeeService;
		public employee(IemployeeService iemployeeService)
		{
			_iemployeeService = iemployeeService;

		}
		[HttpGet]
		[Route("getEmployeeregistration")]
		public async Task<IActionResult> getEmployeeregistration()
		{
			var employeeregistrationDetails = _iemployeeService.getEmployeeRegistration();
			return Ok(employeeregistrationDetails);
		}
		[HttpGet]
		[Route("getEmployeeregistrationListbyID")]
		public async Task<IActionResult> getEmployeeregistrationListbyID(int Id)
		{
			var employeeregistrationDetails = _iemployeeService.getEmployeeRegistrationListByID(Id);
			return Ok(employeeregistrationDetails);
		}

		[HttpPost]
		[Route("saveEmployeeregistrationDetails")]
		public async Task<IActionResult> saveEmployeeregistrationDetails([FromForm] empRequestUpload requestUpload)
		{
			empRegistrationdto data = JsonConvert.DeserializeObject<empRegistrationdto>(requestUpload.strData.ToString());
            data.formPic = requestUpload.pic;
            var employeeregistrationDetails = _iemployeeService.saveEmployeeRegistration(data);
			return Ok(employeeregistrationDetails);
		}
        #region DROP DOWN

        [HttpGet]
        [Route("getGender")]
        public async Task<IActionResult> getGender()
        {
            var gender = _iemployeeService.getGender();
            if (gender == null)
            {
                return NotFound();
            }
            return Ok(gender);
        }

        [HttpGet]
        [Route("getHolidayGroup")]
        public async Task<IActionResult> getHolidayGroup()
        {
            var holidayGroup = _iemployeeService.getHolidayGroup();
            if (holidayGroup == null)
            {
                return NotFound();
            }
            return Ok(holidayGroup);
        }

        [HttpGet]
        [Route("getJobGrade")]
        public async Task<IActionResult> getJobGrade()
        {
            var jobGrade = _iemployeeService.getJobGrade();
            if (jobGrade == null)
            {
                return NotFound();
            }
            return Ok(jobGrade);
        }

        [HttpGet]
        [Route("getMaritalStatus")]
        public async Task<IActionResult> getMaritalStatus()
        {
            var maritalStatus = _iemployeeService.getMaritalStatus();
            if (maritalStatus == null)
            {
                return NotFound();
            }
            return Ok(maritalStatus);
        }

        [HttpGet]
        [Route("getOTType")]
        public async Task<IActionResult> getOTType()
        {
            var getOTType = _iemployeeService.getOTType();
            if (getOTType == null)
            {
                return NotFound();
            }
            return Ok(getOTType);
        }

        [HttpGet]
        [Route("getProbition")]
        public async Task<IActionResult> getProbition()
        {
            var getProbition = _iemployeeService.getProbition();
            if (getProbition == null)
            {
                return NotFound();
            }
            return Ok(getProbition);
        }

        [HttpGet]
        [Route("getRestDay")]
        public async Task<IActionResult> getRestDay()
        {
            var getRestDay = _iemployeeService.getRestDay();
            if (getRestDay == null)
            {
                return NotFound();
            }
            return Ok(getRestDay);
        }

        [HttpGet]
        [Route("getSection")]
        public async Task<IActionResult> getSection()
        {
            var getSection = _iemployeeService.getSection();
            if (getSection == null)
            {
                return NotFound();
            }
            return Ok(getSection);
        }


        [HttpGet]
        [Route("getStatus")]
        public async Task<IActionResult> getStatus()
        {
            var getStatus = _iemployeeService.getStatus();
            if (getStatus == null)
            {
                return NotFound();
            }
            return Ok(getStatus);
        }
        [HttpGet]
        [Route("getWorkingHoursShift")]
        public async Task<IActionResult> getWorkingHoursShift()
        {
            var getWorkingHoursShift = _iemployeeService.getWorkingHoursShift();
            if (getWorkingHoursShift == null)
            {
                return NotFound();
            }
            return Ok(getWorkingHoursShift);
        }

        [HttpGet]
        [Route("getDepartment")]
        public async Task<IActionResult> getDepartment()
        {
            var getDepartment = _iemployeeService.getDepartment();
            if (getDepartment == null)
            {
                return NotFound();
            }
            return Ok(getDepartment);
        }


        [HttpGet]
        [Route("getDesignation")]
        public async Task<IActionResult> getDesignation()
        {
            var getDesignation = _iemployeeService.getDesignation();
            if (getDesignation == null)
            {
                return NotFound();
            }
            return Ok(getDesignation);
        }
        [HttpGet]
        [Route("getemployee")]
        public async Task<IActionResult> getemployee()
        {
            var getemployee = _iemployeeService.getEmployee();
            if (getemployee == null)
            {
                return NotFound();
            }
            return Ok(getemployee);
        }

        #endregion
        // GET: api/<employee>
        [HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<employee>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<employee>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<employee>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<employee>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
