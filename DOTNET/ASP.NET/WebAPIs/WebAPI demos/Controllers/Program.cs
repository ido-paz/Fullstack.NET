namespace Controllers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            
            var app = builder.Build();

            app.UseStaticFiles();

            app.MapDefaultControllerRoute();

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}