using AutoMapper;
using CleanArchitecture.Application.Automapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Mvc.Configurations
{
    public static class AutomapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArchitecture.Application.Automapper.AutomapperConfiguration));
            AutomapperConfiguration.RegisterMappings();
        }
    }
}
