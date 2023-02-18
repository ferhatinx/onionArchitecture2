using Application.Interfaces.Repository;
using Domain.Entities;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class ProductRepository : GenericReadRepository<Product>, IProductRepository
    {
        public ProductRepository(OnionConttext context) : base(context)
        {
        }
    }
}
    