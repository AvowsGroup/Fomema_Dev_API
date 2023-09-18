using Fomema.DAL.DBContexts;
using Fomema.DAL.DBEntities;
using Fomema.Model.common;
using Fomema.Model.timesheet;
using Fomema.Repository.interfaces;
using Fomema.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Fomema.Utility.FileUpload;

namespace Fomema.Repository.implementations
{
	public class timeSheetRepository : ItimesheetRepository
	{
		AppDBContext appDBContext = new AppDBContext();
		private readonly AppDBContext _appDBContext;
		public timeSheetRepository(AppDBContext appDBContext)
		{
			_appDBContext = appDBContext;
		}
		#region timesheet
		public List<timesheetRegistrationDto> gettimesheetRegistration()
		{
			try
			{
				var timesheetList = appDBContext.Registration1.Select(x => new timesheetRegistrationDto
				{
					clock_date = x.ClockDate,
					clock_day = x.ClockDay,
					shift_time_in = x.ShiftTimeIn,
					shift_time_out = x.ShiftTimeOut,
					actual_time_in = x.ActualTimeIn,
					actual_time_out = x.ActualTimeOut,
					actual_ot_hr = x.ActualOtHr,
					lateness = x.Lateness,
					early_out = x.EarlyOut,
					requested_time_in = x.RequestedTimeIn,
					requested_time_out = x.RequestedTimeOut,
					requested_ot_hr = x.RequestedOtHr,
					reason = x.Reason,
					remarks = x.Remarks,
					status = x.Status,
					id = x.Id,
					requested_lateness = x.RequestedLateness
					,
					requested_earlyout = x.RequestedEarlyout
				}).ToList();
				return timesheetList;
			}
			catch (Exception ex)
			{

				return null;
			}
		}
		public timesheetRegistrationDto gettimesheetRegistrationListByID(int Id)
		{
			var timesheelist = appDBContext.Registration1.Where(x => x.Id == Id).Select(x => new timesheetRegistrationDto
			{
				clock_date = x.ClockDate,
				clock_day = x.ClockDay,
				shift_time_in = x.ShiftTimeIn,
				shift_time_out = x.ShiftTimeOut,
				actual_time_in = x.ActualTimeIn,
				actual_time_out = x.ActualTimeOut,
				actual_ot_hr = x.ActualOtHr,
				lateness = x.Lateness,
				early_out = x.EarlyOut,
				requested_time_in = x.RequestedTimeIn,
				requested_time_out = x.RequestedTimeOut,
				requested_ot_hr = x.RequestedOtHr,
				reason = x.Reason,
				remarks = x.Remarks,
				status = x.Status,
				statusname=x.Status!=null? x.StatusNavigation.Description:null,
				id = x.Id,
				requested_lateness = x.RequestedLateness
				,
				requested_earlyout = x.RequestedEarlyout

			}).FirstOrDefault();
			return timesheelist;
		}
		public responseModel savetimesheetRegistration(timesheetRegistrationDto timesheetRegistrationDto)
		{
			try
			{
				var Savetimesheetregistration = appDBContext.Registration1.Where(x => x.Id == timesheetRegistrationDto.id).FirstOrDefault();
				Registration1 timesheetregistration = new Registration1
				{
					ClockDate = timesheetRegistrationDto.clock_date,
					ClockDay = timesheetRegistrationDto.clock_day,
					ShiftTimeIn = timesheetRegistrationDto.shift_time_in,
					ShiftTimeOut = timesheetRegistrationDto.shift_time_out,
					ActualTimeIn = timesheetRegistrationDto.actual_time_in,
					ActualTimeOut = timesheetRegistrationDto.actual_time_out,
					ActualOtHr = timesheetRegistrationDto.actual_ot_hr,
					Lateness = timesheetRegistrationDto.lateness,
					EarlyOut = timesheetRegistrationDto.early_out,
					RequestedTimeIn = timesheetRegistrationDto.requested_time_in,
					RequestedTimeOut = timesheetRegistrationDto.requested_time_out,
					RequestedOtHr = timesheetRegistrationDto.requested_ot_hr,

					Remarks = timesheetRegistrationDto.remarks,
					Status = timesheetRegistrationDto.status
					,
					RequestedLateness = timesheetRegistrationDto.requested_lateness,
					RequestedEarlyout = timesheetRegistrationDto.requested_earlyout

				};
				if (Savetimesheetregistration == null)
				{
					timesheetregistration.CreatedDate = DateTime.Now;
					if (timesheetRegistrationDto.formattach != null)
					{
						fileUploadResponse response = FileUpload.UploadFile(timesheetRegistrationDto.formattach, FileUploadPath.formatphoto, true);
						timesheetregistration.Guidfileattach = response.uploadedFileName;
						timesheetregistration.Formattach = response.originalFileName;
					}
					appDBContext.Registration1.Add(timesheetregistration);
				}
				else
				{
					Savetimesheetregistration.RequestedTimeIn = timesheetRegistrationDto.requested_time_in;
					Savetimesheetregistration.RequestedTimeOut = timesheetRegistrationDto.requested_time_out;
					Savetimesheetregistration.RequestedOtHr = timesheetRegistrationDto.requested_ot_hr;
					Savetimesheetregistration.Remarks = timesheetRegistrationDto.remarks;
					Savetimesheetregistration.Status = timesheetRegistrationDto.status;
					Savetimesheetregistration.RequestedLateness = timesheetRegistrationDto.requested_lateness;
					Savetimesheetregistration.RequestedEarlyout = timesheetRegistrationDto.requested_earlyout;
					if (timesheetRegistrationDto.statusname != null)
						Savetimesheetregistration.Status = getStatusbyname(timesheetRegistrationDto.statusname);
					if (timesheetRegistrationDto.formattach != null)
					{
						fileUploadResponse response = FileUpload.UploadFile(timesheetRegistrationDto.formattach, FileUploadPath.formattimesheet, true);
						timesheetregistration.Guidfileattach = response.uploadedFileName;
						timesheetregistration.Formattach = response.originalFileName;
					}
					fileuploaddto fileuploaddto = new fileuploaddto();
					fileuploaddto.timesheet_id = timesheetRegistrationDto.id;
					fileuploaddto.description = timesheetregistration.Formattach;
					fileuploaddto.guidfilename = timesheetregistration.Guidfileattach;

					savefileupload(fileuploaddto);
				}
				appDBContext.SaveChanges();
				return new responseModel
				{
					IsSuccess = false,
					Messsage = timesheetregistration.Id.ToString()// constants.successMessage
				};
			}
			catch (Exception ex)
			{
				return new responseModel
				{
					IsSuccess = false,
					Messsage = ex.Message
				};

			};
		}
		#endregion
		#region Drop Down 
		public int? getStatusbyname(string name)
		{
			var statusResult = _appDBContext.Status1.Where(x => x.Description == name).FirstOrDefault();
			if (statusResult != null)
				return statusResult.Id;
			else
				return null;
		}
		public responseModel savefileupload(fileuploaddto fileuploaddto)
		{
			try
			{
				Fileupload fileupload = new Fileupload
				{
					TimesheetId = fileuploaddto.timesheet_id,
				};
				fileupload.CreatedDate = DateTime.Now;
				fileupload.Description = fileuploaddto.description;
				fileupload.Guidfilename = fileuploaddto.guidfilename;
				appDBContext.Fileupload.Add(fileupload);
				appDBContext.SaveChanges();
				return new responseModel
				{
					IsSuccess = false,
					Messsage = fileupload.Id.ToString()// constants.successMessage
				};
			}
			catch (Exception ex)
			{
				return new responseModel
				{
					IsSuccess = false,
					Messsage = ex.Message
				};

			};
		}
		public responseModel Deletefileuploads(int id)
		{
			try
			{
				var fileuploads = appDBContext.Fileupload.Where(x => x.Id == id).FirstOrDefault();
				appDBContext.Fileupload.Remove(fileuploads);
				appDBContext.SaveChanges();
				return new responseModel
				{
					IsSuccess = true,
					Messsage = ""
				};

			}
			catch (Exception ex)
			{
				return new responseModel
				{
					IsSuccess = false,
					Messsage = ex.Message
				};
			}
		}
		public List<fileuploaddto> FileuploadList(int Id)
		{
			try
			{
				var fileuploadList = appDBContext.Fileupload.Where(x=>x.TimesheetId==Id).Select(x => new fileuploaddto
				{
					description=x.Description,
					guidfilename=x.Guidfilename,
					timesheet_id=x.TimesheetId
					,Id=x.Id
					
				}).ToList();
				return fileuploadList;
			}
			catch (Exception ex)
			{

				return null;
			}
		}
		#endregion
	}
}
