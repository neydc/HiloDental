using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProyDentoWeb.BD;
using ProyDentoWeb.Models;

namespace ProyDentoWeb.Controllers
{

    public class ClienteController : Controller
    {

        private AppDBContext _db;
public readonly IConfiguration configuration;
        public ClienteController(AppDBContext db, IConfiguration configuration)
        {
            this.configuration = configuration;
            _db = db;
        }

        public IActionResult Index()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = _db.Clientes.Where(o => o.usuario == claim.Value).FirstOrDefault();
            ViewBag.Citas = _db.Citas.Include(o => o.horario).Include(o => o.doctor).Include(o => o.cliente).Where(o => o.idCliente == user.idCliente).ToList();

            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }


        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if (!ModelState.IsValid)
            { 

                return View();

            }

            cliente.codigo = "C - " + cliente.usuario;

            var pass = CreateHash(cliente.passwd);
            cliente.passwd = pass;
            _db.Clientes.Add(cliente);
            _db.SaveChanges();

            return RedirectToAction("Index", "Cliente");


        }
private string CreateHash(string input)
        {
            var sha = SHA256.Create();
            input += configuration.GetValue<string>("Token");
            var hash = sha.ComputeHash(Encoding.Default.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

    }

    
}
