

using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Core.Interfaces;


namespace API.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {



        private readonly iProductRepository _repo;

        public ProductsController(iProductRepository repo){
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _repo.GetProductsAsync();
            return Ok(products);
          
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
           
            var product = await _repo.GetProductByIdAsync(id);
            
           
            if (product == null)
            {
                return NotFound();
            }

            return product;

            

        }
        
    }
}