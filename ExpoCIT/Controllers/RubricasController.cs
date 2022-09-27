using Microsoft.AspNetCore.Mvc;

namespace ExpoCIT.Controllers
{
    public class RubricasController : Controller
    {
        public IActionResult FormProyecto()
        {
            return View();
        }

        public IActionResult FormTrabajoEscrito()
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
    }
}
