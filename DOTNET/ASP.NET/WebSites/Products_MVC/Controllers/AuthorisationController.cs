using Microsoft.AspNetCore.Mvc;

namespace Products_MVC.Controllers
{
    public class AuthorisationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
