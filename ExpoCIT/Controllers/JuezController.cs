using ExpoCIT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ExpoCIT.Controllers
{
    [Authorize]
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
            var claims = User.Identities.First().Claims.ToList();

            int id;
            int.TryParse(claims?.FirstOrDefault(x => x.Type == "Id")?.Value, out id);

            var juez = _db.Jueces.Include(x => x.Proyectos).First(x => x.Id == id);

            return View(juez);
        }

        [HttpPost]
        public IActionResult VerRubrica(int idProyecto, TipoRubrica btnPresionado)
        {
            switch (btnPresionado)
            {
                case TipoRubrica.ProyectoExpoIngenieria:
                    return RedirectToAction("FormProyectoExpoIngenieria", new { idProyecto = idProyecto});
                case TipoRubrica.TrabajoEscritoExpoIngenieria:
                    return RedirectToAction("FormTrabajoEscritoExpoIngenieria", new { idProyecto = idProyecto });
                case TipoRubrica.ProyectoExpoJovem:
                    return RedirectToAction("FormProyectoExpoJovem", new { idProyecto = idProyecto });
                default:
                    return RedirectToAction("Index");
            }
        }

        public IActionResult FormProyectoExpoIngenieria(int idProyecto)
        {
            var rubricaProyecto = _db.RPEIs.Include(x => x.Proyecto).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            rubricaProyecto ??= new RPEI();
            rubricaProyecto.Proyecto = _db.Proyectos.Find(idProyecto) ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            return View("FormProyecto", rubricaProyecto);
        }

        [HttpPost]
        public IActionResult FormProyectoExpoIngenieria(RPEI rpei, int idProyecto, string firma)
        {
            var dbRPEI = _db.RPEIs.Include(x => x.Proyecto).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            dbRPEI ??= new RPEI();
            rpei.Proyecto = _db.Proyectos.Find(idProyecto) ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            rpei.I_subtotal = rpei.I_a + rpei.I_b + rpei.I_c + rpei.I_d + rpei.I_e;
            rpei.II_subtotal = rpei.II_a + rpei.II_b + rpei.II_c + rpei.II_d + rpei.II_e + rpei.II_f;
            rpei.III_subtotal = rpei.III_a + rpei.III_b + rpei.III_c + rpei.III_d + rpei.III_e;
            rpei.IV_subtotal = rpei.IV_a + rpei.IV_b + rpei.IV_c + rpei.IV_d + rpei.IV_e + rpei.IV_f;
            rpei.V_subtotal = rpei.V_a + rpei.V_b + rpei.V_c + rpei.V_d + rpei.V_e + rpei.V_f;
            rpei.VI_subtotal = rpei.VI_a + rpei.VI_b + rpei.VI_c + rpei.VI_d + rpei.VI_e + rpei.VI_f + rpei.VI_g + rpei.VI_h;
            rpei.VII_subtotal = rpei.VII_a + rpei.VII_b + rpei.VII_c + rpei.VII_d + rpei.VII_e + rpei.VII_f;
            rpei.VIII_subtotal = rpei.VIII_a + rpei.VIII_b + rpei.VIII_c + rpei.VIII_d;

            rpei.estado = true;

            var encodedImage = firma.Split(',')[1];
            var decodedImage = Convert.FromBase64String(encodedImage);
            rpei.FirmaDigital = decodedImage;

            dbRPEI = rpei;
            if (dbRPEI.Id == 0)
            {
                _db.RPEIs.Add(dbRPEI);
            }

            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult FormTrabajoEscritoExpoIngenieria(int idProyecto)
        {
            var rubricaTrabajoEscrito = _db.RTEIs.Include(x => x.Proyecto).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            rubricaTrabajoEscrito ??= new RTEEI();
            rubricaTrabajoEscrito.Proyecto = _db.Proyectos.Find(idProyecto) ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            return View("FormTrabajoEscrito", rubricaTrabajoEscrito);
        }

        [HttpPost]
        public IActionResult FormTrabajoEscritoExpoIngenieria(RTEEI rteei)
        {
            RTEEI? dbRTEEI = _db.RTEIs.Find(rteei.Id);

            if (dbRTEEI == null)
                return View();

            dbRTEEI = rteei;

            _db.SaveChanges();
            return View("Index");
        }

        public IActionResult FormProyectoExpoJovem(int idProyecto)
        {
            var rubricaProyecto = _db.RTEJs.Include(x => x.Proyecto).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            rubricaProyecto ??= new RPEJ();
            rubricaProyecto.Proyecto = _db.Proyectos.Find(idProyecto) ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            return View(rubricaProyecto);
        }

        [HttpPost]
        public IActionResult FormProyectoExpoJovem(RPEJ rpej)
        {
            RPEJ? dbRPEJ = _db.RTEJs.Find(rpej.Id);

            if (dbRPEJ == null)
                return View();

            dbRPEJ = rpej;

            _db.SaveChanges();
            return View("Index");
        }
    }
}
