using ExpoCIT.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ExpoCIT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ExpoContext _db;

        public HomeController(ILogger<HomeController> logger, ExpoContext db)
        {
            _logger = logger;
            _db = db;
        }

        public ActionResult LoginJuez()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> LoginJuez(Juez juez)
        {
            var dbJuez = _db.Jueces.FirstOrDefault(j => j.Cedula == juez.Cedula && j.Contrasena == juez.Contrasena);
            if (dbJuez == null)
            {
                return View();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.GivenName, dbJuez.Nombre),
                new Claim(ClaimTypes.Surname, $"{dbJuez.PrimerApellido} {dbJuez.SegundoApellido}"),
                new Claim(ClaimTypes.Name, $"{dbJuez.Nombre} {dbJuez.PrimerApellido} {dbJuez.SegundoApellido}"),
                new Claim("Id", dbJuez.Id.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Login");

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            return RedirectToAction("Index", "Juez");
        }

        public ActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> LoginUser(Usuario usuario)
        {
            var dbUsuario = _db.Usuarios.FirstOrDefault(u => u.Username == usuario.Username && u.Contrasena == usuario.Contrasena);
            if (dbUsuario == null)
            {
                return View();
            }
            
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.GivenName, dbUsuario.Nombre),
                new Claim(ClaimTypes.Surname, $"{dbUsuario.PrimerApellido} {dbUsuario.SegundoApellido}"),
                new Claim(ClaimTypes.Name, $"{dbUsuario.Nombre} {dbUsuario.PrimerApellido} {dbUsuario.SegundoApellido}"),
                new Claim("Id", dbUsuario.Id.ToString()),
                new Claim("User", "True")
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Login");

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return RedirectToAction("Index", "User");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("LoginJuez");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult Usuario()
        {
            return View();
        }
    }
}
