using CleanArc.Application.Interfaces;
using CleanArc.Application.Services;
using CleanArc.Domain.Interfaces;
using CleanArc.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IBodyCorpService, BodyCorpService>();
            services.AddScoped<IUnitService, UnitService>();

            //Infra.Data Layer
            services.AddScoped<IBodyCorpRepository, BodyCoprRepository>();
            services.AddScoped<IUnitRepository, UnitRepository>();
        }
    }
}
