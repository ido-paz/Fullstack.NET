using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopDAL;
using ShopWebAPI.DTO;
using ShopWebAPI.Utils;

namespace ShopWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopDbContext _context;
        private readonly FilesManager _FilesManager;

        public ProductsController(ShopDbContext context, FilesManager filesManager)
        {
            _context = context;
            _FilesManager = filesManager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            if (_context.Products == null)
                return NotFound();
            return await _context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            if (_context.Products == null)
                return NotFound();
            var product = await _context.Products.FindAsync(id);

            if (product == null)
                return NotFound();

            return product;
        }

        [HttpPut()]
        public async Task<IActionResult> PutProduct(Product product)
        {
            if (!ProductExists(product.Id))
                return NotFound();
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("withImage")]
        public async Task<IActionResult> PutProductWithImage([FromForm] ProductWithImage pwi)
        {
            await SetImage(pwi);
            return await PutProduct(pwi);
        }
                
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest("request data is invalid");
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Created("/products/" + product.Id, product.Id);
        }

        [HttpPost("withImage")]
        public async Task<ActionResult<Product>> PostProductWithImage([FromForm] ProductWithImage pwi)
        {
            await SetImage(pwi);
            return await PostProduct(pwi);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            //if (!string.IsNullOrEmpty(product.ImageName))
            //    _FilesManager.DeleteFile(product.ImageName);

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        async Task SetImage(ProductWithImage pwi)
        {
            if (pwi.Image != null && pwi.Image.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await pwi.Image.CopyToAsync(memoryStream);
                    //pwi.ImageData = memoryStream.ToArray();
                    pwi.ImageData = _FilesManager.GetImageString(pwi.Image.FileName,memoryStream.ToArray());
                }
                //_FilesManager.SaveFile(pwi.Image);//saving in file system
                pwi.ImageName = pwi.Image.FileName;
            }
        }
    }
}
