namespace Enviroment_Configuration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            if (builder.Environment.IsDevelopment())
            {
                Console.WriteLine("Dev");
            }
            else
            {
                Console.WriteLine(builder.Environment.EnvironmentName);
            }


            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}