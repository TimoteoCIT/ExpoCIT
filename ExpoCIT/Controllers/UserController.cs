using ExpoCIT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExpoCIT.Controllers
{
    [Authorize(Policy = "UserOnly")]
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

        public IActionResult ProyectosEJ()
        {
            return View();
        }
        public IActionResult ProyectosEI()
        {
            return View();
        }

        public IActionResult BtnFormProyecto(int idProyecto)
        {
            return RubricaProyecto(idProyecto);
        }

        public IActionResult BtnFormTrabajoEscrito(int idProyecto)
        {
            return RubricaTrabajoEscrito(idProyecto);
        }

        public IActionResult Juez()
        {
            return View();
        }

        public IActionResult RubricaProyectoExpoJovem(int idProyecto)
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