using Fomema.Model.common;
using Fomema.Model.employeeregistration;
using System.Collections.Generic;

namespace Fomema.Repository.interfaces
{
	public interface IemployeeRepository
	{
		#region employee
		responseModel saveEmployeeRegistration(empRegistrationdto employeeRegistrationDto);
		empRegistrationdto getEmployeeRegistrationListByID(int Id);
		List<empRegistrationdto> getEmployeeRegistration();
        #endregion
        #region DropDown
        List<dropdownDto> getWorkingHoursShift();
        List<dropdownDto> getStatus();
        List<dropdownDto> getOTType();
        List<dropdownDto> getRestDay();
        List<dropdownDto> getProbition();
        List<dropdownDto> getHolidayGroup();
        List<dropdownDto> getJobGrade();
        List<dropdownDto> getSection();
        List<dropdownDto> getDesignation();
        List<dropdownDto> getDepartment();
        List<dropdownDto> getMaritalStatus();
        List<dropdownDto> getGender();
        List<dropdownDto> getEmployee();
        #endregion
    }
}
