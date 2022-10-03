using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpoCIT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult LoginJuez()
        {
            return View();
        }
        public ActionResult LoginUser()
        {
            return View();
        }
        public IActionResult Usuario()
        {
            return View();
        }
    }
}
