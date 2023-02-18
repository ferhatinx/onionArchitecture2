using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class ProductDto : IDto
    {
        public string? Name { get; set; }
        public decimal Value { get; set; }

        public int Quantity { get; set; }
    }
}
