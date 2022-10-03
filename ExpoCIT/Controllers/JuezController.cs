using Microsoft.AspNetCore.Mvc;

namespace ExpoCIT.Controllers
{
    public class JuezController : Controller
    {
        private readonly ILogger<JuezController> _logger;
        private readonly ExpoContext _db;

        public JuezController(ILogger<JuezController> logger, ExpoContext db)
        {
            _logger = logger;
            _db = db;
        }

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
