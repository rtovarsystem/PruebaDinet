using DinetApi.Models;
using DinetApi.Interfaces;
using DinetApi.Repositories;
using System.Data;
using Microsoft.AspNetCore.Mvc;

namespace DinetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly IProductosRepository _repository;

        public ProductosController(IProductosRepository repository)
        {
            _repository = repository;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Productos>>> GetProductos()
        //{
        //    var dProductos = await _repository.GetAllProductosAsync();
        //    return Ok(dProductos);
        //}

        [HttpGet("ListarProductos")]
        public async Task<IActionResult> listarProductos()
        {
            var lista = await _repository.GetAllProductosAsync();

            return Ok(lista);
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Product>> GetProduct(int id)
        //{
        //    var Product = await _repository.GetProductByIdAsync(id);
        //    if (Product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(Product);
        //}

        //[HttpPost]
        //public async Task<ActionResult<Productos>> CreateProduct(Productos dProductos)
        //{
        //    int newProductoId = await _repository.CreateProductosAsync(dProductos);
        //    dProductos.Id = newProductoId;
        //    return CreatedAtAction(nameof(GetProductos), new { id = newProductoId }, dProductos);
        //}

        [HttpPost("RegistrarProductos")]
        public async Task<IActionResult> registrarProductos([FromBody] Productos model)
        {
            
            var rpta = await _repository.CreateProductosAsync(model);

            return Ok(rpta);
        }


        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateProduct(int id, Product Product)
        //{
        //    if (id != Product.Id)
        //    {
        //        return BadRequest();
        //    }

        //    bool updated = await _repository.UpdateProductAsync(Product);
        //    if (!updated)
        //    {
        //        return NotFound();
        //    }

        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProduct(int id)
        //{
        //    bool deleted = await _repository.DeleteProductAsync(id);
        //    if (!deleted)
        //    {
        //        return NotFound();
        //    }
        //    return NoContent();
        //}
    }
}
