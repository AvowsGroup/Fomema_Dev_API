﻿using Fomema.Model.common;
using Fomema.Model.timesheet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Repository.interfaces
{
	public interface ItimesheetRepository
	{
		List<timesheetRegistrationDto> gettimesheetRegistration();
		timesheetRegistrationDto gettimesheetRegistrationListByID(int Id);
		responseModel savetimesheetRegistration(timesheetRegistrationDto timesheetRegistrationDto);
		responseModel savefileupload(fileuploaddto fileuploaddto);
		responseModel Deletefileuploads(int id);
		List<fileuploaddto> FileuploadList(int Id);
	}
}
