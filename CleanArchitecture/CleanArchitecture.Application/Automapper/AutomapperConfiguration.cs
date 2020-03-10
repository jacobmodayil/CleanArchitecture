using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Automapper
{
    public class AutomapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ViewModelToDomainProfile());
                cfg.AddProfile(new DomainToViewModelProfile());
            });
        }
    }
}
