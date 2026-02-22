using Microsoft.Extensions.DependencyInjection;
using SchoolManagement.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Application.ServicesInterfaces;
namespace SchoolManagement.Application
{

    public static class DependencyInjectionApplication
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();


            return services;
        }
    }
}

