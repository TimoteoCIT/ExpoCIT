using ExpoCIT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExpoCIT.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly ExpoContext _db;

        public UserController(ILogger<UserController> logger, ExpoContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerRubrica(int idProyecto, TipoRubrica btnPresionado)
        {
            switch (btnPresionado)
            {
                case TipoRubrica.ProyectoExpoIngenieria:
                    return RedirectToAction("RubricaProyecto", new { idProyecto = idProyecto });
                case TipoRubrica.TrabajoEscritoExpoIngenieria:
                    return RedirectToAction("RubricaTrabajoEscrito", new { idProyecto = idProyecto });
                case TipoRubrica.ProyectoExpoJovem:
                    return RedirectToAction("RubricaProyectoExpoJovem", new { idProyecto = idProyecto });
                default:
                    return RedirectToAction("Index");
            }
        }

        public IActionResult ProyectosEJ()
        {
            var ProyectosEJ = _db.Proyectos.ToList().FindAll(x => x.TipoProyecto == TipoProyecto.ExpoJovem);
            return View(ProyectosEJ);
        }

        public IActionResult ProyectosEI()
        {
            var ProyectosEI = _db.Proyectos.ToList().FindAll(x => x.TipoProyecto == TipoProyecto.ExpoIngenieria);
            return View(ProyectosEI);
        }

        public IActionResult Juez()
        {
            return View();
        }

        public IActionResult RubricaProyecto(int idProyecto)
        {
            return View();
        }

        public IActionResult RubricaTrabajoEscrito(int idProyecto)
        {
            return View();
        }

        public IActionResult RubricaProyectoExpoJovem(int idProyecto)
        {
            return View();
        }

        public IActionResult Ganadores()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}