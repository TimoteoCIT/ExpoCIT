using ExpoCIT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                    return RedirectToAction("RubricaProyectoExpoIngenieria", new { idProyecto = idProyecto });
                case TipoRubrica.TrabajoEscritoExpoIngenieria:
                    return RedirectToAction("RubricaTrabajoEscritoExpoIngenieria", new { idProyecto = idProyecto });
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

        public IActionResult RubricaProyectoExpoIngenieria(int idProyecto)
        {
            var rpei = _db.RPEIs.Include(x => x.Proyecto).ThenInclude(x => x.Juez).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            rpei ??= new RPEI();
            rpei.Proyecto = _db.Proyectos
                .Include(x => x.Juez)
                .FirstOrDefault(x => x.Id == idProyecto)
                ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            return View("RubricaProyecto", rpei);
        }

        public IActionResult RubricaTrabajoEscritoExpoIngenieria(int idProyecto)
        {
            var rteei = _db.RTEIs.Include(x => x.Proyecto).ThenInclude(x => x.Juez).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            rteei ??= new RTEEI();
            rteei.Proyecto = _db.Proyectos
                .Include(x => x.Juez)
                .FirstOrDefault(x => x.Id == idProyecto)
                ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            return View("RubricaTrabajoEscrito", rteei);
        }

        public IActionResult RubricaProyectoExpoJovem(int idProyecto)
        {
            var rpej = _db.RTEJs.Include(x => x.Proyecto).ThenInclude(x => x.Juez).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            rpej ??= new RPEJ();
            rpej.Proyecto = _db.Proyectos
                .Include(x => x.Juez)
                .FirstOrDefault(x => x.Id == idProyecto)
                ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            return View(rpej);
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