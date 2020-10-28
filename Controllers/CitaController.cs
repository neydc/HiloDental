using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProyDentoWeb.BD;
using ProyDentoWeb.Models;

namespace ProyDentoWeb.Controllers
{
    [Authorize]
    public class CitaController : Controller
    {
private AppDBContext _db;
public readonly IConfiguration configuration;
        public CitaController(AppDBContext db, IConfiguration configuration)
        {
            this.configuration = configuration;
            _db = db;
        }

        [Authorize]
        [HttpGet]
        public ActionResult CreatePaciente() {
            ViewBag.Doctores = _db.Doctors.ToList();


            ViewBag.Horarios = _db.Horarios.ToList();


            return View("CreatePaciente");
        }
        [HttpPost]
        public ActionResult CreatePaciente(DateTime fecha,int idHorario,int idDoctor){
            if (!ModelState.IsValid)
            {
                return View();
            }
            Cita cita = new Cita();
            cita.fecha = Convert.ToDateTime(fecha.ToString("dd-MM-yyyy"));
            cita.idHorario =  idHorario;
            cita.estado = "True";
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = _db.Clientes.Where(o => o.usuario == claim.Value).FirstOrDefault();
            
            cita.idCliente = user.idCliente;

            cita.idDoctor = idDoctor;
            cita.monto = 0;
            _db.Citas.Add(cita);
            _db.SaveChanges();

            return RedirectToAction("Index", "Cliente");
        }
    }
}