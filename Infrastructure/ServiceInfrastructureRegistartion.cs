using Application.Dtos;
using Application.ValdationRules;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ServiceInfrastructureRegistartion
    {
        public static void  AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IValidator<ProductDto>, ProductValidator>();
        }
    }
}
