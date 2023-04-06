using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop_WebAPI_React.Models;
namespace Shop_WebAPI_React.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Models.ShopContext _context;
        public ProductsController(ShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts() 
        {
            return Ok(_context.Products.ToList());
        }
    }
}
