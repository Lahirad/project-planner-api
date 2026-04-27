using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Application
{
    public  static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
           
            return services;
        }   
    }
}
