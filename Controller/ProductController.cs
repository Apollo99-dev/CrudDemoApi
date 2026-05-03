using Microsoft.AspNetCore.Mvc;
using CrudDemoApi.Models;
using CrudDemoApi.Services;

namespace CrudDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        // GET: api/Product?pageNumber=1&pageSize=5
        [HttpGet]
        public IActionResult GetAll(int pageNumber = 1, int pageSize = 5)
        {
            var products = _service.GetAll(pageNumber, pageSize);
            return Ok(products);
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _service.GetById(id);
            if (product == null)
                return NotFound("Product not found");

            return Ok(product);
        }

        // POST: api/Product
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
                return BadRequest("Product name is required");

            if (product.Price <= 0)
                return BadRequest("Price must be greater than zero");

            var result = _service.Create(product);
            return Ok(result);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, Product updatedProduct)
        {
            if (string.IsNullOrWhiteSpace(updatedProduct.Name))
                return BadRequest("Product name is required");

            if (updatedProduct.Price <= 0)
                return BadRequest("Price must be greater than zero");

            var product = _service.Update(id, updatedProduct);
            if (product == null)
                return NotFound("Product not found");

            return Ok(product);
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);
            if (!result)
                return NotFound("Product not found");

            return Ok("Product deleted successfully");
        }
    }
}