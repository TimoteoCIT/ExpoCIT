using ExpoCIT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExpoCIT.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        public IActionResult Usuario()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Juez()
        {
            return View();
        }

        public IActionResult RubricaProyecto()
        {
            return View();
        }
        public IActionResult RubricaTrabajoEscrito()
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