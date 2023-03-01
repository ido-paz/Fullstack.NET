using Microsoft.AspNetCore.Mvc;

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
    public ActionResult<List<Product>> GetAll()
    {
        return Ok(Products);
    }

    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        return Ok(Products.FirstOrDefault(p => p.Id == id));
    }

    [HttpPost]
    public ActionResult Add(Product newProduct)
    {
        //if (newProduct.Id < 1)
        //    throw new ArgumentException("id must be above 0");
        //if (newProduct.Price < 1)
        //    throw new ArgumentException("Price must be above 0");
        return Created("Products/" + newProduct.Id, "Add->" + newProduct.ToString());
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id) 
    {
        if (Products.Exists(p => p.Id == id))
            return NoContent();
        else
            return NotFound();
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id)
    {
        if (Products.Exists(p => p.Id == id))
            return NoContent();
        else
            return NotFound();
    }


    [HttpPost("Add2")]
    public string Add2([FromBody]Product newProduct)
    {
        return "Add2->" + newProduct.ToString();
    }

    [HttpPost("Add3")]
    public string Add3([FromForm] Product newProduct)
    {
        return "Add3->" + newProduct.ToString();
    }

    [HttpPost("Add4")]
    public string Add4([FromQuery] Product newProduct)
    {
        return "Add4->" + newProduct.ToString();
    }

    [HttpPost("Add5/{Id}/{Name}/{Price}")]
    public string Add5([FromRoute] Product newProduct)
    {
        return "Add5->" + newProduct.ToString();
    }

}
