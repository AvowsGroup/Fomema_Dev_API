using Fomema.Model.employeeregistration;
using Fomema.Model.users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Services.interfaces
{
	public interface IuserService
	{
		List<menudto> getMenuList();
		empRegistrationdto authenticate(authenticateRequestModel model);
	}
}
