using CrudOperationWithInterface.Models;
using CrudOperationWithInterface.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudOperationWithInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        // what is the dependency injection?



        // Dependency Injection means rather then writing all the in the same controller we can call from the outside.



        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }



        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            //Command and query architecture (CQRS) - It is a design pattern that separates the read and write operations of a system into two distinct models. The command model is responsible for handling write operations, while the query model is responsible for handling read operations. This separation allows for better scalability, performance, and maintainability of the system, as each model can be optimized for its specific purpose without affecting the other.
            var products = _productService.GetAll();
            return Ok(products);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost("Add")]
        public IActionResult Add(Product product)
        {
            _productService.Add(product);
            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult Update(Product product)
        {
            _productService.Update(product);
            return Ok();
        }
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return Ok();
        }
    }
}
