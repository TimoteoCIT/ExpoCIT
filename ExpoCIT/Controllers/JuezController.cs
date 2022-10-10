using ExpoCIT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

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
            var rubricaProyecto = _db.RPEIs.Include(x => x.Proyecto).ThenInclude(x => x.Juez).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
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
            var rubricaTrabajoEscrito = _db.RTEIs.Include(x => x.Proyecto).ThenInclude(x => x.Juez).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            rubricaTrabajoEscrito ??= new RTEEI();
            rubricaTrabajoEscrito.Proyecto = _db.Proyectos.Find(idProyecto) ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            return View("FormTrabajoEscrito", rubricaTrabajoEscrito);
        }

        [HttpPost]
        public IActionResult FormTrabajoEscritoExpoIngenieria(RTEEI rteei, int idProyecto, string firma)
        {
            RTEEI? dbRTEEI = _db.RTEIs.Include(x => x.Proyecto).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            dbRTEEI ??= new RTEEI();
            rteei.Proyecto = _db.Proyectos.Find(idProyecto) ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            rteei.I_subtotal = rteei.I_a + rteei.I_b + rteei.I_c + rteei.I_d + rteei.I_e;
            rteei.II_subtotal = rteei.II_a + rteei.II_b + rteei.II_c + rteei.II_d + rteei.II_e + rteei.II_f;
            rteei.III_subtotal = rteei.III_a + rteei.III_b + rteei.III_c + rteei.III_d;
            rteei.IV_subtotal = rteei.IV_a + rteei.IV_b + rteei.IV_c + rteei.IV_d + rteei.IV_e;
            rteei.V_subtotal = rteei.V_a + rteei.V_b + rteei.V_c + rteei.V_d + rteei.V_e + rteei.V_f;
            rteei.VI_subtotal = rteei.VI_a + rteei.VI_b + rteei.VI_c + rteei.VI_d + rteei.VI_e + rteei.VI_f;
            rteei.VII_subtotal = rteei.VII_a + rteei.VII_b + rteei.VII_c + rteei.VII_d + rteei.VII_e;
            rteei.VIII_subtotal = rteei.VIII_a + rteei.VIII_b + rteei.VIII_c + rteei.VIII_d + rteei.VIII_e;

            rteei.P_1 = "";
            rteei.P_2 = "";
            rteei.P_3 = "";
            rteei.P_4 = "";
            rteei.P_5 = "";
            rteei.P_6 = "";
            rteei.P_7 = "";
            rteei.P_8 = "";
            rteei.P_9 = "";
            rteei.P_10 = "";
            rteei.P_11 = "";
            rteei.P_12 = "";
            rteei.P_13 = "";

            rteei.DG ??= "";

            rteei.estado = true;

            var encodedImage = firma.Split(',')[1];
            var decodedImage = Convert.FromBase64String(encodedImage);
            rteei.FirmaDigital = decodedImage;

            dbRTEEI = rteei;

            if (dbRTEEI.Id == 0)
            {
                _db.RTEIs.Add(dbRTEEI);
            }

            _db.SaveChanges();
            return RedirectToAction("Index");
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
