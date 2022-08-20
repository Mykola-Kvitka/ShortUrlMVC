using Microsoft.Extensions.DependencyInjection;
using ShortUrlMVC.BLL.Interfaces;
using ShortUrlMVC.BLL.Models;
using ShortUrlMVC.BLL.Services;
using ShortUrlMVC.DAL;
using ShortUrlMVC.DAL.Interfaces;
using ShortUrlMVC.DAL.Models;
using ShortUrlMVC.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrlMVC.PL.Infastructure
{
    public static class DependencyConfiguration
    {
        public static void AddDependencies(this IServiceCollection service)
        {
            //DAL configuration
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddTransient<IGenericRepository<ShortURLEntity>, GenericRepository<ShortURLEntity>>();

            //BL configuration
            service.AddTransient<IShortURLService, ShortUrlService>();
        }

    }
}
