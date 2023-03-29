using Microsoft.AspNetCore.Mvc;

namespace Products_MVC.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
