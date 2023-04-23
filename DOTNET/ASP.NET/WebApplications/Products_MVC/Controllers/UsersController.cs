using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop_MVC.Models;

namespace Shop_MVC.Controllers
{
    public class UsersController : Controller
    {
        ShopContext _shopContext;
        public UsersController(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public IActionResult Index()
        {
            return View(_shopContext.Users);
        }

        public IActionResult Delete(int id)
        {
            var userInDB = _shopContext.Users.FirstOrDefault(u => u.UserId == id);
            if (userInDB == null)
            {
                return NotFound();
            }
            else
            {
                _shopContext.Remove(userInDB);
                _shopContext.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public IActionResult Edit(int id)
        {
            return View(_shopContext.Users.FirstOrDefault(u => u.UserId == id));
        }

        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            var userInDB = _shopContext.Users.FirstOrDefault(u => u.UserId == updatedUser.UserId);
            if (userInDB == null)
            {
                return NotFound();
            }
            else
            {
                userInDB.UserName = updatedUser.UserName;
                userInDB.PhoneNumber = updatedUser.PhoneNumber;
                _shopContext.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User newUser)
        {
            _shopContext.Add(newUser);
            _shopContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
