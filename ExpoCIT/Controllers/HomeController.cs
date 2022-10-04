using ExpoCIT.Models;
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

        [HttpPost]
        public ActionResult LoginJuez(Juez juez)
        {
            if (_db.Jueces.FirstOrDefault(j => j.Cedula == juez.Cedula && j.Contrasena == juez.Contrasena) == null)
            {
                return View();
            }

            return RedirectToAction("Index", "Juez");
        }

        public ActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(Usuario usuario)
        {
            if (_db.Usuarios.FirstOrDefault(u => u.Username == usuario.Username && u.Contrasena == usuario.Contrasena) == null)
            {
                return View();
            }

            return RedirectToAction("Index", "User");
        }

        public IActionResult Usuario()
        {
            return View();
        }
    }
}
