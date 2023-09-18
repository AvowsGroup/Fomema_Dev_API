using Fomema.Repository.implementations;
using Fomema.Repository.interfaces;
using Fomema.Services.implementations;
using Fomema.Services.interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Root.CustomInjection
{
	public static class AppRoot
	{
        public static void InjectAppDependencies(this IServiceCollection services)
        {
            InjectServiceDependencies(services);
            InjectProviderDependicies(services);
            InjectRepositoryDependencies(services);

        }
        private static void InjectServiceDependencies(IServiceCollection services)
        {
            services.AddTransient<IemployeeService, employeeService>();
            services.AddTransient<ItimeSheetService, timeSheetService>();
            services.AddTransient<IuserService, usersService>();

        }

        private static void InjectProviderDependicies(IServiceCollection services)
        {
        }

        private static void InjectRepositoryDependencies(IServiceCollection services)
        {
            services.AddTransient<IemployeeRepository, employeeRepository>();
            services.AddTransient<ItimesheetRepository, timeSheetRepository>();
            services.AddTransient<Iusersrepository, usersRepository>();

        }
    }
}
