using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                //it will scan the assembly for all MediatR handlers, requests, and notifications and register them with the DI container.
                configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly); 
                
            });

            return services;
        }
    }
}
