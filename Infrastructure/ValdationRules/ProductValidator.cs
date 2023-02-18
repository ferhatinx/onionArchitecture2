using Application.Dtos;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ValdationRules
{
   public class ProductValidator : AbstractValidator<ProductDto>
    {
        public ProductValidator()
        {
               RuleFor(x=>x.Name).NotEmpty();
               RuleFor(X=>X.Value).NotEmpty();
        }
    }
}
