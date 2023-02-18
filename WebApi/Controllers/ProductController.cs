using Application.Interfaces.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productrepository;
        public ProductController(IProductRepository productrepository)
        {
            _productrepository= productrepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var productlist =await _productrepository.GetAllAsync();
            return Ok(productlist);
            
        }
    }
}
