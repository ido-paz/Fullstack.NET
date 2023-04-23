using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop_RazorPages.Models;

namespace Shop_RazorPages.Pages.Products
{
    public class CreateModel : PageModel
    {
        ShopContext _ShopContext;

        public CreateModel(ShopContext shopContext)
        {
            _ShopContext = shopContext;
        }

        public void OnGet()
        {

        }

        public ActionResult OnPost(Product newProduct) 
        {
            _ShopContext.Products.Add(newProduct);
            _ShopContext.SaveChanges();
            return RedirectToPage("/Products/Index");
        }
    }
}
