using Fomema.DAL.DBContexts;
using Fomema.Model.employeeregistration;
using Fomema.Model.users;
using Fomema.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fomema.Repository.implementations
{
	public class usersRepository : Iusersrepository
	{
		AppDBContext appDBContext = new AppDBContext();
		private readonly AppDBContext _appDBContext;
		public usersRepository(AppDBContext appDBContext)
		{
			_appDBContext = appDBContext;
		}
		public empRegistrationdto authenticate(authenticateRequestModel model)
		{
			var user = _appDBContext.Registration.Where(a => a.EmailAddress == model.Username && a.Password == model.Password).FirstOrDefault();
			if (user != null)
			{
				return new empRegistrationdto
				{
					fullName = user.FullName,
					emailAddress = user.EmailAddress,
					id = user.Id,
					shortName = user.ShortName
				};
			}
			return null;
		}
		public List<menudto> getMenuList()
		{
			List<menudto> menudtos = new List<menudto>();
			var menus = appDBContext.Menu.Select(x => new menudto
			{
				parentId = x.ParentId,
				menuName = x.MenuName,
				controllerName = x.ControllerName,
				actionName = x.ActionName

			}).ToList();
			return menudtos;

		}

	}
}
