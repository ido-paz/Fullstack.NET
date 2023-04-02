using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop_RazorPages.Models;

namespace Shop_RazorPages.Pages.Products
{
    public class EditModel : PageModel
    {
        ShopContext _ShopContext;
        public Product Product { get; set; }

        public EditModel(ShopContext shopContext)
        {
            _ShopContext = shopContext;
        }

        public void OnGet(int id)
        {
            Product = _ShopContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public ActionResult OnPost(Product updatedProduct) 
        {
            var productInDB = _ShopContext.Products.FirstOrDefault(p => p.Id == updatedProduct.Id);
            if (productInDB != null)
            {
                productInDB.Name= updatedProduct.Name;
                productInDB.Price= updatedProduct.Price;
                _ShopContext.SaveChanges();
                return RedirectToPage("/Products/Index");
            }
            return NotFound();
        }

    }
}
