using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDSAMR.Infrastructure
{
    public static class InfraIOC
    {
        public static IServiceCollection AddInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<RDSAMRContext>(options =>
            //options.UseSqlServer(@"server=RITECH-PC\SQLEXPRESS;Database=AMCDB;Integrated Security= true;"));
             options.UseSqlServer(configuration.GetConnectionString("scon")));
            return services;
        }
    }
}
