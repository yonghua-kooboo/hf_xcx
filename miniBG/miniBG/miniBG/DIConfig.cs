using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Mini.Bll;
using Mini.Dal;
using Mini.Data;
using Mini.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniBG
{
    public static class DIConfig
    {
        public static void RegisterComponents(IServiceCollection services)
        {
            services.AddTransient<MiniDbContext>();
            services.AddTransient(typeof(IDataProvider<>), typeof(DataProvider<>));
            services.AddTransient<IBaseDataService, BaseDataService>();
        }
    }
}
