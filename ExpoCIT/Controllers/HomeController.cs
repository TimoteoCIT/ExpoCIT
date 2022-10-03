using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpoCIT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ExpoContext _db;

        public HomeController(ILogger<HomeController> logger, ExpoContext db)
        {
            _logger = logger;
            _db = db;
        }

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
