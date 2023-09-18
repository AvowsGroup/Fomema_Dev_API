using Fomema.DAL.DBContexts;
using Fomema.DAL.DBEntities;
using Fomema.Model.common;
using Fomema.Model.employeeregistration;
using Fomema.Repository.interfaces;
using Fomema.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using static Fomema.Utility.FileUpload;

namespace Fomema.Repository.implementations
{
	public class employeeRepository:IemployeeRepository
	{
        AppDBContext appDBContext = new AppDBContext();
        private readonly AppDBContext _appDBContext;
        public employeeRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
		#region employee
		/// <summary>
		/// 
		/// </summary>
		/// <param name="employeeRegistrationDto"></param>
		/// <returns></returns>
		public responseModel saveEmployeeRegistration(empRegistrationdto employeeRegistrationDto)
        {
            try
            {
                var Saveemployeeregistration = appDBContext.Registration.Where(x => x.Id == employeeRegistrationDto.id).FirstOrDefault();
                Registration employeeregistration = new Registration
                {
                    EmployeeCode = employeeRegistrationDto.employeeCode,
                    FullName = employeeRegistrationDto.fullName,
                    ShortName = employeeRegistrationDto.shortName,
                    Gender = employeeRegistrationDto.gender,
                    MaritalStatus = employeeRegistrationDto.maritalStatus,
                    BiometricId = employeeRegistrationDto.biometricId,
                    JoinDate = employeeRegistrationDto.joinDate,
                    ResignDate = employeeRegistrationDto.resignDate,
                    ConfirmationDate = employeeRegistrationDto.confirmationDate,
                    Probation = employeeRegistrationDto.probation,
                    EmailAddress = employeeRegistrationDto.emailAddress,
                    Mobileno = employeeRegistrationDto.mobileNo,
                    Department = employeeRegistrationDto.department,
                    Section = employeeRegistrationDto.section,
                    HolidayGroup = employeeRegistrationDto.holidayGroup,
                    Designation = employeeRegistrationDto.designation,
                    FirstLevelApproval = employeeRegistrationDto.firstLevelApproval,
                    SecondLevelApproval = employeeRegistrationDto.secondLevelApproval,
                    ThirdLevelApproval = employeeRegistrationDto.thirdLevelApproval,
                    HoursWorkedDay = employeeRegistrationDto.hoursWorkedDay,
                    DayWorkedWeek = employeeRegistrationDto.dayWorkedWeek,
                    HoursWorkedYear = employeeRegistrationDto.hoursWorkedyear,
                    JobGrade = employeeRegistrationDto.jobGrade,
                    Status = employeeRegistrationDto.status,
                    Hourly = employeeRegistrationDto.hourly,
                    WorkingHoursPerShift = employeeRegistrationDto.workingHourseperShift,
                    Ottype = employeeRegistrationDto.otType,
                    ReasonResignation = employeeRegistrationDto.reasonResignation,
                    RestDay = employeeRegistrationDto.restDay,
                    Password = RandomString(10)
                };
                if (Saveemployeeregistration == null)
                {
                    employeeregistration.CreatedDate = DateTime.Now;
                    if (employeeRegistrationDto.formPic != null)
                    {
						fileUploadResponse response =FileUpload.UploadFile(employeeRegistrationDto.formPic, FileUploadPath.formatphoto, true);
						employeeregistration.Empguidfilename = response.uploadedFileName;
						employeeregistration.Emppic = response.originalFileName;
					}
                    appDBContext.Registration.Add(employeeregistration);
                }
                else
                {
                    Saveemployeeregistration.EmployeeCode = employeeRegistrationDto.employeeCode;
                    Saveemployeeregistration.FullName = employeeRegistrationDto.fullName;
                    Saveemployeeregistration.ShortName = employeeRegistrationDto.shortName;
                    Saveemployeeregistration.Gender = employeeRegistrationDto.gender;
                    Saveemployeeregistration.MaritalStatus = employeeRegistrationDto.maritalStatus;
                    Saveemployeeregistration.BiometricId = employeeRegistrationDto.biometricId;
                    Saveemployeeregistration.JoinDate = employeeRegistrationDto.joinDate;
                    Saveemployeeregistration.ResignDate = employeeRegistrationDto.resignDate;
                    Saveemployeeregistration.ConfirmationDate = employeeRegistrationDto.confirmationDate;
                    Saveemployeeregistration.Probation = employeeRegistrationDto.probation;
                    Saveemployeeregistration.EmailAddress = employeeRegistrationDto.emailAddress;
                    Saveemployeeregistration.Mobileno = employeeRegistrationDto.mobileNo;
                    Saveemployeeregistration.Department = employeeRegistrationDto.department;
                    Saveemployeeregistration.Section = employeeRegistrationDto.section;
                    Saveemployeeregistration.HolidayGroup = employeeRegistrationDto.holidayGroup;
                    Saveemployeeregistration.Designation = employeeRegistrationDto.designation;
                    Saveemployeeregistration.FirstLevelApproval = employeeRegistrationDto.firstLevelApproval;
                    Saveemployeeregistration.SecondLevelApproval = employeeRegistrationDto.secondLevelApproval;
                    Saveemployeeregistration.ThirdLevelApproval = employeeRegistrationDto.thirdLevelApproval;
                    Saveemployeeregistration.HoursWorkedDay = employeeRegistrationDto.hoursWorkedDay;
                    Saveemployeeregistration.DayWorkedWeek = employeeRegistrationDto.dayWorkedWeek;
                    Saveemployeeregistration.HoursWorkedYear = employeeRegistrationDto.hoursWorkedyear;
                    Saveemployeeregistration.JobGrade = employeeRegistrationDto.jobGrade;
                    Saveemployeeregistration.Status = employeeRegistrationDto.status;
                    Saveemployeeregistration.Hourly = employeeRegistrationDto.hourly;
                    Saveemployeeregistration.WorkingHoursPerShift = employeeRegistrationDto.workingHourseperShift;
                    Saveemployeeregistration.Ottype = employeeRegistrationDto.otType;
                    Saveemployeeregistration.ReasonResignation = employeeRegistrationDto.reasonResignation;
                    Saveemployeeregistration.RestDay = employeeRegistrationDto.restDay;
                    if (employeeRegistrationDto.formPic != null)
                    {
                        fileUploadResponse response = FileUpload.UploadFile(employeeRegistrationDto.formPic, FileUploadPath.formatphoto, true);
                        Saveemployeeregistration.Empguidfilename = response.uploadedFileName;
                        Saveemployeeregistration.Emppic = response.originalFileName;
                    }

                }
                appDBContext.SaveChanges();
                return new responseModel
                {
                    IsSuccess = false,
                    Messsage = employeeregistration.Id.ToString()// constants.successMessage
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public empRegistrationdto getEmployeeRegistrationListByID(int Id)
        {
            var employeeList = appDBContext.Registration.Where(x => x.Id == Id).Select(x => new empRegistrationdto
            {
                employeeCode = x.EmployeeCode,
                fullName = x.FullName,
                shortName = x.ShortName,
                gender=x.Gender,
                empPic=x.Emppic,
               guidemppic=x.Empguidfilename,
                gendername = x.Gender!=null? x.GenderNavigation.Description:null,
                maritalStatus = x.MaritalStatus,
                biometricId = x.BiometricId,
                joinDate = x.JoinDate,
                resignDate = x.ResignDate,
                confirmationDate = x.ConfirmationDate,
                probation = x.Probation,
                emailAddress = x.EmailAddress,
                mobileNo = x.Mobileno,
                department=x.Department,
                departmentname = x.Department!=null?x.DepartmentNavigation.Description:null,
                sectionname=x.Section!=null? x.SectionNavigation.Description:null,
                section = x.Section,
                designation = x.Designation,
                designationname=x.Designation!=null?x.DesignationNavigation.Description:null,
                holidayGroup = x.HolidayGroup,
                firstLevelApproval = x.FirstLevelApproval,
                secondLevelApproval = x.SecondLevelApproval,
                thirdLevelApproval = x.ThirdLevelApproval,
                status = x.Status,
                otType = x.Ottype,
                jobGrade = x.JobGrade,
                hoursWorkedDay = x.HoursWorkedDay,
                workingHourseperShift = x.WorkingHoursPerShift,
                dayWorkedWeek = x.DayWorkedWeek,
                hoursWorkedyear = x.HoursWorkedYear,
                hourly = x.Hourly,
                reasonResignation = x.ReasonResignation,
                restDay = x.RestDay,

            }).FirstOrDefault();
            return employeeList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<empRegistrationdto> getEmployeeRegistration()
        {
            try
            {
                var employeeregistrationList = appDBContext.Registration.Select(x => new empRegistrationdto
                {
                    employeeCode = x.EmployeeCode,
                    fullName = x.FullName,
                    shortName = x.ShortName,
                    
                    gender = x.Gender,
                    gendername = x.Gender != null ? x.GenderNavigation.Description : null,
                    maritalStatus = x.MaritalStatus,
                    biometricId = x.BiometricId,
                    joinDate = x.JoinDate,
                    resignDate = x.ResignDate,
                    confirmationDate = x.ConfirmationDate,
                    probation = x.Probation,
                    emailAddress = x.EmailAddress,
                    mobileNo = x.Mobileno,
                    department = x.Department,
                    departmentname = x.Department != null ? x.DepartmentNavigation.Description : null,
                    sectionname = x.Section != null ? x.SectionNavigation.Description : null,
                    section = x.Section,
                    designation = x.Designation,
                    designationname = x.Designation != null ? x.DesignationNavigation.Description : null,
                    holidayGroup = x.HolidayGroup,
                    firstLevelApproval = x.FirstLevelApproval,
                    secondLevelApproval = x.SecondLevelApproval,
                    thirdLevelApproval = x.ThirdLevelApproval,
                    status = x.Status,
                    otType = x.Ottype,
                    jobGrade = x.JobGrade,
                    hoursWorkedDay = x.HoursWorkedDay,
                    workingHourseperShift = x.WorkingHoursPerShift,
                    dayWorkedWeek = x.DayWorkedWeek,
                    hoursWorkedyear = x.HoursWorkedYear,
                    hourly = x.Hourly,
                    reasonResignation = x.ReasonResignation,
                    restDay = x.RestDay,
                    id = x.Id,

                }).ToList();
                return employeeregistrationList;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Drop Down 
        public List<dropdownDto> getGender()
        {
            var genderResult = _appDBContext.Gender.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;
        }

        public List<dropdownDto> getMaritalStatus()
        {
            var genderResult = _appDBContext.Maritalstatus.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;
        }
        public List<dropdownDto> getDepartment()
        {
            var genderResult = _appDBContext.Department.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;
        }
        public List<dropdownDto> getDesignation()
        {
            var genderResult = _appDBContext.Designation.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;
        }
        public List<dropdownDto> getSection()
        {
            var genderResult = _appDBContext.Section.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;
        }
        public List<dropdownDto> getJobGrade()
        {
            var genderResult = _appDBContext.Jobgrade.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;
        }
        public List<dropdownDto> getHolidayGroup()
        {
            var genderResult = _appDBContext.Holidaygroup.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;
        }
        public List<dropdownDto> getProbition()
        {
            var genderResult = _appDBContext.Probation.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;
        }
        public List<dropdownDto> getRestDay()
        {
            var genderResult = _appDBContext.RestDay.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;

        }
        public List<dropdownDto> getOTType()
        {
            var genderResult = _appDBContext.Ottype.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;
        }
        public List<dropdownDto> getStatus()
        {
            var genderResult = _appDBContext.Status.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;
        }
        public List<dropdownDto> getWorkingHoursShift()
        {
            var genderResult = _appDBContext.WorkingHoursShift.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.Description
            }).ToList();
            return genderResult;
        }
        public List<dropdownDto> getEmployee()
        {
            var genderResult = _appDBContext.Registration.Select(x => new dropdownDto
            {
                id = x.Id,
                name = x.FullName
            }).ToList();
            return genderResult;
        }
        #endregion
        public static Random random = new Random();
        public static string RandomString(int length)
        {
            var specialLength = (int)Math.Ceiling(length / 4d);
            var lowerUpperLength = (int)Math.Ceiling(length / 3d);
            var numericLength = (int)Math.Ceiling(length / 2d);

            var special = Enumerable.Repeat("!@#$%^&|+-.,?", specialLength)
                .Select(chars => chars[random.Next(chars.Length)]).ToArray();
            var lower = Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", lowerUpperLength)
                .Select(chars => chars[random.Next(chars.Length)]).ToArray();
            var upper = Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ", lowerUpperLength)
                .Select(chars => chars[random.Next(chars.Length)]).ToArray();
            var numeric = Enumerable.Repeat("0123456789", numericLength)
                .Select(chars => chars[random.Next(chars.Length)]).ToArray();

            var scrambledConcat = special.Concat(lower)
                .Concat(upper).Concat(numeric)
                .ToArray();

            var scrambledChars = Enumerable.Repeat(scrambledConcat, length)
                .Select(chars => chars[random.Next(chars.Length)]).ToArray();

            return new string(scrambledChars);
        }
    }
}
