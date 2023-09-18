using Fomema.Model.employeeregistration;
using Fomema.Model.users;
using Fomema.Repository.interfaces;
using Fomema.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Services.implementations
{
	public class usersService:IuserService
	{
		private readonly Iusersrepository _iusersrepository;
		public void Dispose()
		{
		}
		public usersService(Iusersrepository iusersrepository)
		{
			_iusersrepository = iusersrepository;
		}
		public List<menudto> getMenuList()
		{
			return _iusersrepository.getMenuList();
		}
		public empRegistrationdto authenticate(authenticateRequestModel model)
		{
			return _iusersrepository.authenticate(model);
		}
	}
}
