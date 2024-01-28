using ApplicationWebASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationWebASP.Controllers
{
    public class LoginInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Fitback fitback)
        {
            if (ModelState.IsValid) {
                return Redirect("/");
            }
            return View("Index");
            
        }
    }
}
