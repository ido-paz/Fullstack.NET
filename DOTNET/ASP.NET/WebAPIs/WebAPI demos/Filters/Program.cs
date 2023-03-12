using Filters.Filters;

namespace Filters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers(c =>
            {
                c.Filters.Add<ActionMethodLogger>();
                c.Filters.Add<AddHeaderFilter>();
            });

            var app = builder.Build();

            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}