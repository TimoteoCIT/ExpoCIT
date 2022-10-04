﻿using ExpoCIT.Models;
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
            var rubricaProyecto = _db.RPEIs.Include(x => x.Proyecto).FirstOrDefault(x => x.Proyecto.Id == idProyecto);
            rubricaProyecto ??= new RPEI();
            rubricaProyecto.Proyecto = _db.Proyectos.Find(idProyecto) ?? throw new InvalidOperationException("Deberia ser imposible que el id del proyecto no exista");

            return View("FormProyecto", rubricaProyecto);
        }

        [HttpPost]
        public IActionResult FormProyectoExpoIngenieria(RPEI rpei)
        {
            RPEI? dbRPEI = _db.RPEIs.Find(rpei.Id);

            if (dbRPEI == null)
                return View();

            dbRPEI = rpei;

            _db.SaveChanges();
            return View("Index");
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

            return View("FormTrabajoEscrito", rubricaProyecto);
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
