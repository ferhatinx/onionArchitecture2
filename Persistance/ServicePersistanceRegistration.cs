using Application.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Context;
using Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public static class ServicePersistanceRegistration
    {
        public static void AddPersistance(this IServiceCollection services)
        {
            services.AddDbContext<OnionConttext>(opt => 
                {
                    opt.UseInMemoryDatabase("DbOnionmemory"); 
                }
            );
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
