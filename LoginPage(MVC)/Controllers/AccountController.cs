using Microsoft.AspNetCore.Mvc;
using LoginPage_MVC_.Models;

namespace LoginPage_MVC_.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Verify(Account acc)
        {
            return View();
        }
    }
}
