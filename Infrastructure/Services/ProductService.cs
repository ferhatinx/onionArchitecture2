using Application.Dtos;
using Application.Enums;
using Application.Interfaces.Repository;
using Application.Wrappers;
using FluentValidation;
using Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productrepository;
        private readonly IValidator<ProductDto> _validator;

        public ProductService(IProductRepository productrepository, IValidator<ProductDto> validator)
        {
            _productrepository = productrepository;
            _validator = validator;
        }
            

        public async Task<GenericServiceResponse<List<ProductDto>>> GerAllProduct()
        {
           var products =await _productrepository.GetAllAsync();
           var productDto = new List<ProductDto>();
            if (products != null)
            {
                
                foreach (var product in products)
                {
                    productDto.Add(new ProductDto { Name = product.Name, Value = product.Value, Quantity = product.Quantity });
                }
                return new GenericServiceResponse<List<ProductDto>>(productDto);
                    
            }
            return new GenericServiceResponse<List<ProductDto>>(productDto,ResponseType.NotFound);





        }
        

    }
}
