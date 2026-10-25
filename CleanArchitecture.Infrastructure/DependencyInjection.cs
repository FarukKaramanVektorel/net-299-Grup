using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service,IConfiguration config)
        {
            var cs = config.GetConnectionString("Default") ?? "Data Source=orders.db";
            service.AddDbContext<AppDbContext>(o => o.UseSqlite(cs));
            service.AddScoped<IOrderRepository, OrderRepository>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            return service;
        }


    }
}
