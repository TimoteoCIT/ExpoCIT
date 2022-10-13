using ExpoCIT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
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
            var rubricaProyecto = _db.RPEIs.Include(x => x.Proyecto).ThenInclude(x => x.Juez).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            rubricaProyecto ??= new RPEI();
            rubricaProyecto.Proyecto = _db.Proyectos
                .Include(x => x.Juez)
                .FirstOrDefault(x => x.Id == idProyecto)
                ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            return View("FormProyecto", rubricaProyecto);
        }

        [HttpPost]
        public IActionResult FormProyectoExpoIngenieria(RPEI rpei, int idProyecto, string firma)
        {
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

            if (rpei.Id == 0)
            {
                _db.RPEIs.Add(rpei);
            } else
            {
                _db.Update(rpei);
            }

            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult FormTrabajoEscritoExpoIngenieria(int idProyecto)
        {
            var rubricaTrabajoEscrito = _db.RTEIs.Include(x => x.Proyecto).ThenInclude(x => x.Juez).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            rubricaTrabajoEscrito ??= new RTEEI();
            rubricaTrabajoEscrito.Proyecto = _db.Proyectos
                .Include(x => x.Juez)
                .FirstOrDefault(x => x.Id == idProyecto)
                ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            return View("FormTrabajoEscrito", rubricaTrabajoEscrito);
        }

        [HttpPost]
        public IActionResult FormTrabajoEscritoExpoIngenieria(RTEEI rteei, int idProyecto, string firma)
        {
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

            rteei.estado = true;

            var encodedImage = firma.Split(',')[1];
            var decodedImage = Convert.FromBase64String(encodedImage);
            rteei.FirmaDigital = decodedImage;

            if (rteei.Id == 0)
            {
                _db.RTEIs.Add(rteei);
            } else
            {
                _db.Update(rteei);
            }

            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult FormProyectoExpoJovem(int idProyecto)
        {
            var rubricaProyecto = _db.RTEJs.Include(x => x.Proyecto).ThenInclude(x => x.Juez).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            rubricaProyecto ??= new RPEJ();
            rubricaProyecto.Proyecto = _db.Proyectos
                .Include(x => x.Juez)
                .FirstOrDefault(x => x.Id == idProyecto)
                ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            return View(rubricaProyecto);
        }

        [HttpPost]
        public IActionResult FormProyectoExpoJovem(RPEJ rpej, int idProyecto, string firma)
        {
            rpej.Proyecto = _db.Proyectos.Find(idProyecto) ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            rpej.I_subtotal = rpej.I_a + rpej.I_b + rpej.I_c + rpej.I_d + rpej.I_e;
            rpej.II_subtotal = rpej.II_a + rpej.II_b + rpej.II_c + rpej.II_d + rpej.II_e + rpej.II_f;
            rpej.III_subtotal = rpej.III_a + rpej.III_b + rpej.III_c + rpej.III_d + rpej.III_e;
            rpej.IV_subtotal = rpej.IV_a + rpej.IV_b + rpej.IV_c + rpej.IV_d + rpej.IV_e + rpej.IV_f;
            rpej.V_subtotal = rpej.V_a + rpej.V_b + rpej.V_c + rpej.V_d + rpej.V_e;
            rpej.VI_subtotal = rpej.VI_a + rpej.VI_b + rpej.VI_c + rpej.VI_d;
            rpej.VII_subtotal = rpej.VII_a + rpej.VII_b + rpej.VII_c + rpej.VII_d;

            rpej.estado = true;

            var encodedImage = firma.Split(',')[1];
            var decodedImage = Convert.FromBase64String(encodedImage);
            rpej.FirmaDigital = decodedImage;

            if (rpej.Id == 0)
            {
                _db.RTEJs.Add(rpej);
            }
            else
            {
                _db.Update(rpej);
            }

            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
