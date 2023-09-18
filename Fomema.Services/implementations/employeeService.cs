using Fomema.Model.common;
using Fomema.Model.employeeregistration;
using Fomema.Repository.interfaces;
using Fomema.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Services.implementations
{
	public class employeeService:IemployeeService
	{
		private readonly IemployeeRepository _iemployeeRepository;
		public void Dispose()
		{
		}
		public employeeService(IemployeeRepository iemployeeRepository)
		{
			_iemployeeRepository = iemployeeRepository;
		}
		#region employee
		/// <summary>
		/// 
		/// </summary>
		/// <param name="empRegistrationdto"></param>
		/// <returns></returns>
		public responseModel saveEmployeeRegistration(empRegistrationdto empRegistrationdto)
		{
			return _iemployeeRepository.saveEmployeeRegistration(empRegistrationdto);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		public empRegistrationdto getEmployeeRegistrationListByID(int Id)
		{
			return _iemployeeRepository.getEmployeeRegistrationListByID(Id);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public List<empRegistrationdto> getEmployeeRegistration()
		{
			return _iemployeeRepository.getEmployeeRegistration();
		}
        #endregion
        #region DropDown
        public List<dropdownDto> getGender()
        {
            return _iemployeeRepository.getGender();
        }
        public List<dropdownDto> getWorkingHoursShift()
        {
            return _iemployeeRepository.getWorkingHoursShift();
        }
        public List<dropdownDto> getStatus()
        {
            return _iemployeeRepository.getWorkingHoursShift();
        }
        public List<dropdownDto> getOTType()
        {
            return _iemployeeRepository.getOTType();
        }
        public List<dropdownDto> getRestDay()
        {
            return _iemployeeRepository.getRestDay();
        }
        public List<dropdownDto> getProbition()
        {
            return _iemployeeRepository.getProbition();
        }
        public List<dropdownDto> getHolidayGroup()
        {
            return _iemployeeRepository.getHolidayGroup();
        }
        public List<dropdownDto> getJobGrade()
        {
            return _iemployeeRepository.getJobGrade();
        }
        public List<dropdownDto> getSection()
        {
            return _iemployeeRepository.getSection();
        }
        public List<dropdownDto> getDesignation()
        {
            return _iemployeeRepository.getDesignation();
        }
        public List<dropdownDto> getDepartment()
        {
            return _iemployeeRepository.getDepartment();
        }
        public List<dropdownDto> getMaritalStatus()
        {
            return _iemployeeRepository.getMaritalStatus();
        }
        public List<dropdownDto> getEmployee()
        {
            return _iemployeeRepository.getEmployee();
        }
        #endregion
    }
}
