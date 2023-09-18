using Fomema.Model.employeeregistration;
using Fomema.Model.users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Repository.interfaces
{
	public interface Iusersrepository
	{
		List<menudto> getMenuList();
		empRegistrationdto authenticate(authenticateRequestModel model);
	}
}
