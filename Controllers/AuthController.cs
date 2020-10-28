using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProyDentoWeb.BD;

namespace ProyDentoWeb.Controllers
{
    public class AuthController : BaseController
    {


        private readonly AppDBContext _db;
        public readonly IConfiguration configuration;

        public AuthController(AppDBContext db, IConfiguration configuration) : base(db)
        {
            _db = db;
            this.configuration = configuration;
        }


        [Authorize]
        public string LoggedUserView(string tipo)
        {
            if(tipo == "doc"){
                return "El usuario Logeuado es:" + LoggedDoctor().usuario;
            }
            else{
                return "El usuario Logeuado es:" + LoggedUser().usuario;
            }
            
        }


        [HttpGet]
        public string Index(string input)
        {
            return CreateHash(input);
        }

        private string CreateHash(string input)
        {
            var sha = SHA256.Create();
            input += configuration.GetValue<string>("Token");
            var hash = sha.ComputeHash(Encoding.Default.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            /* validar si el usuario existe en la base de datos y 
             * verificar que el password sea correcto*/
            var user = _db.Clientes
                .Where(o => o.usuario == username && o.passwd == CreateHash(password))
                .FirstOrDefault();

            if (user != null)
            {
                // Autenticaremos
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, username)
                };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("Index", "Cliente");
            }

            ModelState.AddModelError("Login", "Usuario o contraseña incorrectos.");
            return View();
        }


        [HttpGet]
        public IActionResult LoginDoctor()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LoginDoctor(string username, string password)
        {
            /* validar si el usuario existe en la base de datos y 
             * verificar que el password sea correcto*/
            var user = _db.Doctors
                .Where(o => o.usuario == username && o.passwd == CreateHash(password))
                .FirstOrDefault();

            if (user != null)
            {
                // Autenticaremos
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, username)
                };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("Index", "Doctor");
            }

            ModelState.AddModelError("Login", "Usuario o contraseña incorrectos.");
            return View();
        }


        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
