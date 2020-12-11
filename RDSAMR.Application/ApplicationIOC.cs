using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RDSAMR.Application.Interfaces;
using RDSAMR.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDSAMR.Application
{
    public static class ApplicationIOC
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IStateService, StateService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddAutoMapper(typeof(AMRProfile));
            return services;
        }
    }
}
