using Products_WebAPI.Models;
using System.Text.Json;

namespace Products_WebAPI.Middlewares
{
    public class ProductsMW
    {
        public List<Product> ProductsDB { get; set; }
        RequestDelegate _Next;

        public ProductsMW(RequestDelegate next) 
        {
            ProductsDB = new List<Product>() 
            { 
                new Product{Id=1,Name="p1",Price=1 },
                new Product{Id=2,Name="p2",Price=2 },
                new Product{Id=3,Name="p3",Price=3 },
                new Product{Id=4,Name="p4",Price=4 }
            };
            _Next = next; 
        }

        public async Task Invoke(HttpContext ctx)
        {
            if (ctx.Request.Path.Value.StartsWith("/products"))
            {
                if (ctx.Request.Method == "GET")
                {
                    string productsJSON = JsonSerializer.Serialize(ProductsDB);
                    ctx.Response.ContentType = "application/json";
                    ctx.Response.WriteAsync(productsJSON);
                }
                else
                {
                    if (ctx.Request.ContentLength == 0)
                    {
                        ctx.Response.StatusCode = StatusCodes.Status400BadRequest;
                        return;
                    }
                    //
                    Product clientProduct = GetProduct(ctx);
                    if (clientProduct == null)
                    {
                        ctx.Response.StatusCode = StatusCodes.Status400BadRequest;
                        return;
                    }
                    //
                    if (ctx.Request.Method == "POST")
                    {
                        if (ProductsDB.Exists(p => p.Id == clientProduct.Id))
                            ctx.Response.StatusCode = StatusCodes.Status400BadRequest;
                        else
                        {
                            ProductsDB.Add(clientProduct);
                            ctx.Response.StatusCode = StatusCodes.Status201Created;
                        }
                    }
                    else if (ctx.Request.Method == "PUT")
                    {
                        Product p = ProductsDB.FirstOrDefault(p => p.Id == clientProduct.Id);
                        if (p  == null)
                            ctx.Response.StatusCode = StatusCodes.Status404NotFound;
                        else
                        {
                            p.Name = clientProduct.Name;
                            p.Price = clientProduct.Price;
                            ctx.Response.StatusCode = StatusCodes.Status204NoContent;
                        }
                    }
                    else if (ctx.Request.Method == "DELETE")
                    {
                        Product p = ProductsDB.FirstOrDefault(p => p.Id == clientProduct.Id);
                        if (p == null)
                            ctx.Response.StatusCode = StatusCodes.Status404NotFound;
                        else
                        {
                            ProductsDB.Remove(p);
                            ctx.Response.StatusCode = StatusCodes.Status204NoContent;
                        }
                    }
                    else
                    {
                        ctx.Response.StatusCode = StatusCodes.Status405MethodNotAllowed;
                    }
                }
            }
            else
                await _Next(ctx);
        }

        private Product GetProduct(HttpContext ctx)
        {
            try
            {
                var body = new StreamReader(ctx.Request.Body).ReadToEndAsync().Result;
                Product p = JsonSerializer.Deserialize<Product>(body);
                return p;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
    }
}
