using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Projects.Commands.Contexts
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddTaskManager(this IServiceCollection services, IConfiguration configuration)
        {
            var connecttionString = configuration["DefaultConnection"];
            services.AddDbContext<TaskManagerDbContext>(options =>
                {
                    options.UseSqlServer(connecttionString);
                });
            services.AddScoped<TaskManagerDbContext>(provider => provider.GetService<TaskManagerDbContext>());
            return services;
        }
    }
}
