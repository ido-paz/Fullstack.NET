using Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    //[Route("abc")]//https://localhost:443/abc
    //[Route("controller")]//https://localhost:443/controller
    [Route("[controller]")]//https://localhost:443/products
    [ApiController]
    public class ProductsController : ControllerBase
    {
        static List<Product> Products { get; set; } = new List<Product>()
        {
            new Product(){Id=1,Name="p1",Price=11},
            new Product(){Id=2,Name="p2",Price=22},
            new Product(){Id=3,Name="p3",Price=33},
            new Product(){Id=4,Name="p4",Price=44},
        };        

        [HttpGet]
        public List<Product> GetAll()
        {
            return Products;
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return Products.FirstOrDefault( p=> p.Id == id);
        }
    }
}
