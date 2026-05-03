using Microsoft.AspNetCore.Mvc;
using CrudDemoApi.Data;
using CrudDemoApi.Models;

namespace CrudDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
                return BadRequest("Product name is required");

            if (product.Price <= 0)
                return BadRequest("Price must be greater than zero");

            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Products.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _context.Products.Find(id);
            return product == null ? NotFound() : Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product updatedProduct)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                return NotFound();

            if (string.IsNullOrWhiteSpace(updatedProduct.Name))
                return BadRequest("Product name is required");

            if (updatedProduct.Price <= 0)
                return BadRequest("Price must be greater than zero");

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;

            _context.SaveChanges();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok("Deleted");

        }


        [HttpGet("search")]
        public IActionResult Search(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return BadRequest("Search term is required");

            var results = _context.Products
                .Where(p => p.Name.ToLower().Contains(name.ToLower()))
                .ToList();

            if (!results.Any())
                return NotFound("No matching products found");

            return Ok(results);
        }

    }
}