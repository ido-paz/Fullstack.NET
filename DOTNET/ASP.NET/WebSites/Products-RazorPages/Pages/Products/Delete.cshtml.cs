using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Products_RazorPages.Models;

namespace Products_RazorPages.Pages.Products
{
    public class DeleteModel : PageModel
    {
        ShopContext _ShopContext;
        public DeleteModel(ShopContext shopContext) 
        { 
            _ShopContext = shopContext;
        }

        public ActionResult OnGet(int id)
        {
            var product = _ShopContext.Products.SingleOrDefault(p => p.Id == id);
            if (product != null)
            {
                _ShopContext.Products.Remove(product);
                _ShopContext.SaveChanges();
                return RedirectToPage("/Products/Index");
            }
            else
            {
                return NotFound();
            }

        }
    }
}
