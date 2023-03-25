using Microsoft.AspNetCore.Mvc.RazorPages;
using Products_RazorPages.Models;

namespace Products_RazorPages.Pages
{
    public class ProductsModel : PageModel
    {
        public string Firstname = "Ido";
        public string Lastname = "Paz";

        public List<Product> Products;

        public void OnGet()
        {
            ShopContext sc = new ShopContext();
            Products = sc.Products.ToList();
        }
    }
}
