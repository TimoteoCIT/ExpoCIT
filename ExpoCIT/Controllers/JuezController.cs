using Microsoft.AspNetCore.Mvc;

namespace ExpoCIT.Controllers
{
    public class JuezController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BtnFormProyecto(int idProyecto)
        {
            return FormProyecto(idProyecto);
        }

        public IActionResult BtnFormTrabajoEscrito(int idProyecto)
        {
            return FormTrabajoEscrito(idProyecto);
        }

        public IActionResult FormProyecto(int idProyecto)
        {
            return View();
        }

        public IActionResult FormTrabajoEscrito(int idProyecto)
        {
            return View();
        }
    }
}
