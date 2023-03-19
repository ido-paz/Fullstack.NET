namespace ShopConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://localhost:7170";
            //var hc = new HttpClient();
            //var wf = await hc.GetStringAsync(url + "/WeatherForecast");
            Client shopClient = new Client(url,new HttpClient());
            //
            var wfc = await shopClient.ProductsAllAsync();
            foreach (var item in wfc)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}