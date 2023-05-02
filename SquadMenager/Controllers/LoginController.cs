using Microsoft.AspNetCore.Mvc;

namespace SquadMenager.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexLogin()
        {
            return View();
        }
    }
}
