using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Fomema.DAL.DBEntities
{
    public partial class Registration
    {
        public Registration()
        {
            InverseFirstLevelApprovalNavigation = new HashSet<Registration>();
            InverseSecondLevelApprovalNavigation = new HashSet<Registration>();
            InverseThirdLevelApprovalNavigation = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public int? Gender { get; set; }
        public int? MaritalStatus { get; set; }
        public string BiometricId { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? ResignDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public int? Probation { get; set; }
        public string EmailAddress { get; set; }
        public string Mobileno { get; set; }
        public string ReasonResignation { get; set; }
        public int? Department { get; set; }
        public int? Section { get; set; }
        public int? Designation { get; set; }
        public int? HolidayGroup { get; set; }
        public string HoursWorkedDay { get; set; }
        public string DayWorkedWeek { get; set; }
        public string HoursWorkedYear { get; set; }
        public int? JobGrade { get; set; }
        public int? FirstLevelApproval { get; set; }
        public int? SecondLevelApproval { get; set; }
        public int? ThirdLevelApproval { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? Status { get; set; }
        public int? Ottype { get; set; }
        public decimal? Hourly { get; set; }
        public int? WorkingHoursPerShift { get; set; }
        public int? RestDay { get; set; }
        public string Password { get; set; }
        public string Emppic { get; set; }
        public string Empguidfilename { get; set; }

        public virtual Department DepartmentNavigation { get; set; }
        public virtual Designation DesignationNavigation { get; set; }
        public virtual Registration FirstLevelApprovalNavigation { get; set; }
        public virtual Gender GenderNavigation { get; set; }
        public virtual Holidaygroup HolidayGroupNavigation { get; set; }
        public virtual Jobgrade JobGradeNavigation { get; set; }
        public virtual Maritalstatus MaritalStatusNavigation { get; set; }
        public virtual Probation ProbationNavigation { get; set; }
        public virtual Registration SecondLevelApprovalNavigation { get; set; }
        public virtual Section SectionNavigation { get; set; }
        public virtual Registration ThirdLevelApprovalNavigation { get; set; }
        public virtual ICollection<Registration> InverseFirstLevelApprovalNavigation { get; set; }
        public virtual ICollection<Registration> InverseSecondLevelApprovalNavigation { get; set; }
        public virtual ICollection<Registration> InverseThirdLevelApprovalNavigation { get; set; }
    }
}
