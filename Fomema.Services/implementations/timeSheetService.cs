using Fomema.Model.common;
using Fomema.Model.timesheet;
using Fomema.Repository.interfaces;
using Fomema.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Services.implementations
{
	public class timeSheetService:ItimeSheetService
	{
		private readonly ItimesheetRepository _itimesheetRepository;
		public void Dispose()
		{
		}
		public timeSheetService(ItimesheetRepository itimesheetRepository)
		{
			_itimesheetRepository = itimesheetRepository;
		}
		public responseModel savetimesheetRegistration(timesheetRegistrationDto timesheetRegistrationDto)
		{
			return _itimesheetRepository.savetimesheetRegistration(timesheetRegistrationDto);
		}
		public timesheetRegistrationDto gettimesheetRegistrationListByID(int Id)
		{
			return _itimesheetRepository.gettimesheetRegistrationListByID(Id);
		}
		public List<timesheetRegistrationDto> gettimesheetRegistration()
		{
			return _itimesheetRepository.gettimesheetRegistration();
		}
		public responseModel savefileupload(fileuploaddto fileuploaddto)
		{
			return _itimesheetRepository.savefileupload(fileuploaddto);
		}
		public responseModel Deletefileuploads(int id)
		{
			return _itimesheetRepository.Deletefileuploads(id);
		}
		public List<fileuploaddto> FileuploadList(int Id)
		{
			return _itimesheetRepository.FileuploadList(Id);
		}
	}
}
