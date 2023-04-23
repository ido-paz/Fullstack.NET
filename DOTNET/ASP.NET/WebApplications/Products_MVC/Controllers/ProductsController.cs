using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Shop_MVC.Models;

namespace Shop_MVC.Controllers
{
    public class ProductsController : Controller
    {
        ShopContext _shopContext;
        public ProductsController(ShopContext shopContext) 
        { 
            _shopContext = shopContext;
        }

        public IActionResult Index()
        {
            return View(_shopContext.Products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                _shopContext.Products.Add(newProduct);
                _shopContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                //var errors = from e in ModelState.AsEnumerable()
                //             where e.Value.ValidationState == ModelValidationState.Invalid
                //             select e.Key + " is invalid";
                var errors = ModelState.AsEnumerable().
                                        Where(m => m.Value.ValidationState == ModelValidationState.Invalid).
                                        Select(m=> m.Key+ " is invalid"); 
                ViewData["Errors"] = errors;
                return View();
            }
        }

        public IActionResult Edit(int id)
        {
            return View(_shopContext.Products.FirstOrDefault(p => p.Id == id));
        }

        public IActionResult Delete(int id)
        {
            var productInDB = _shopContext.Products.FirstOrDefault(p => p.Id ==id);
            if (productInDB == null)
            {
                return NotFound();
            }
            else
            {
                _shopContext.Remove(productInDB);
                _shopContext.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Product updatedProduct) 
        {
            var productInDB = _shopContext.Products.FirstOrDefault(p=> p.Id == updatedProduct.Id);
            if (productInDB == null)
            {
                return NotFound();
            }
            else
            {
                productInDB.Name = updatedProduct.Name;
                productInDB.Price = updatedProduct.Price;
                _shopContext.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public string GetServerTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
