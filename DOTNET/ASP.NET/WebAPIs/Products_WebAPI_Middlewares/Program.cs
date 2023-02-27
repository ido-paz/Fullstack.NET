using Products_WebAPI.Middlewares;
using System.Net;

namespace Products_WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            //
            app.UseMiddleware<ExceptionMW>();
            //
            app.UseMiddleware<ProductsMW>();
            //
            app.Run(async (HttpContext ctx) =>
            {
                ctx.Response.StatusCode = (int)HttpStatusCode.NotFound;
            });
            //
            app.Run();
        }
    }    
}