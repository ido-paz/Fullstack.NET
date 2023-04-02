using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop_RazorPages.Models;

namespace Shop_RazorPages.Pages.Products
{
    public class IndexModel : PageModel
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
