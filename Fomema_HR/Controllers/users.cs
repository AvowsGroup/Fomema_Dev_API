using Fomema.Model.users;
using Fomema.Services.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fomema_HR.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class users : ControllerBase
	{
		private readonly IuserService _iuserService;
		public users(IuserService iuserService)
		{
			_iuserService = iuserService;

		}
		[HttpGet]
		[Route("getMenuList")]
		public async Task<IActionResult> getMenuList()
		{
			var menulistDetails = _iuserService.getMenuList();
			return Ok(menulistDetails);
		}
		[HttpPost("authenticate")]
		
		public async Task<IActionResult> authenticate(authenticateRequestModel model)
		{
			var menulistDetails = _iuserService.authenticate(model);
			return Ok(menulistDetails);
		}
	}
}
