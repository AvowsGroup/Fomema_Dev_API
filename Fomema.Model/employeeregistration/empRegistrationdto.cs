using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Model.employeeregistration
{
	public class empRegistrationdto
	{
        public int id { get; set; }
        public string employeeCode { get; set; }
        public string fullName { get; set; }
        public string shortName { get; set; }
        public int? gender { get; set; }
        public string gendername { get; set; }
        public int? maritalStatus { get; set; }
        public string biometricId { get; set; }
        public DateTime? joinDate { get; set; }
        public DateTime? resignDate { get; set; }
        public DateTime? confirmationDate { get; set; }
        public int? probation { get; set; }
        public string emailAddress { get; set; }
        public string mobileNo { get; set; }
        public string reasonResignation { get; set; }
        public int? department { get; set; }
        public string departmentname { get; set; }
        public int? designation { get; set; }
        public string designationname { get; set; }
        public int? section { get; set; }
        public string sectionname { get; set; }
        public int? holidayGroup { get; set; }
        public string hoursWorkedDay { get; set; }
        public string dayWorkedWeek { get; set; }
        public string hoursWorkedyear { get; set; }
        public int? jobGrade { get; set; }
        public int? firstLevelApproval { get; set; }
        public int? secondLevelApproval { get; set; }
        public int? thirdLevelApproval { get; set; }
        public int? status { get; set; }
        public int? otType { get; set; }
        public decimal? hourly { get; set; }
        public int? workingHourseperShift { get; set; }
        public int? restDay { get; set; }       
        public int createdBy { get; set; }
        public int modifiedBy { get; set; }
        public IFormFile formPic { get; set; }
        public string empPic { get; set; }
        public string guidemppic { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDtae { get; set; }
    }
    public class empRequestUpload
    {
        public string strData { get; set; }
        public IFormFile pic { get; set; }

    }
}
