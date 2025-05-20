using Microsoft.AspNetCore.Mvc;

namespace Excellon.Controllers
{
    public class Login : Controller
    {
        public IActionResult Signin()
        {
            return View();
        }
        public IActionResult Signup()
        {

            return View();
        }
    }
}
