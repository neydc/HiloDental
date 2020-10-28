using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProyDentoWeb.BD;
using ProyDentoWeb.Models;

namespace ProyDentoWeb.Controllers
{
    public class DoctorController : BaseController 
    {
        private AppDBContext _db;
public readonly IConfiguration configuration;
        public DoctorController(AppDBContext db, IConfiguration configuration):base(db)
        {
            this.configuration = configuration;
            _db = db;
        }


        [HttpGet]
        public ActionResult Index(){

            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = _db.Doctors.Where(o => o.usuario == claim.Value).FirstOrDefault();
            ViewBag.Citas = _db.Citas.Include(o => o.horario).Include(o => o.cliente).Where(o => o.idDoctor == LoggedDoctor().idDoctor).ToList();
           
            return View();
        }

        [HttpGet]
        public ActionResult Historial(int idPaciente)
        {
            ViewBag.Id = idPaciente;
            return View();
        }

        [HttpPost]
        public ActionResult Historial(int idPaciente, Historial historial)
        {

            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = _db.Doctors.Where(o => o.usuario == claim.Value).FirstOrDefault();
            Historial historia = new Historial();
            historia.idDoctor = user.idDoctor;
            historia.idCliente = idPaciente;
            historia.numeroHistoria = historial.numeroHistoria;
            historia.observacion = historial.observacion;
            historia.motivo = historial.motivo;
            historia.edad = historial.edad;
            historia.descripcion = historial.descripcion;
            historia.examenes = historial.examenes;
            
            historia.diagnostico = historial.diagnostico;
            historia.tratamiento = historial.tratamiento;
            historia.fecha = DateTime.Now;
            //var cita = _db.Citas.Where(a=>a.);
            _db.Historials.Add(historia);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult HistoriaClinica(int idCita)
        {
            //ViewBag.Id = idPaciente;
            var historial = _db.Historials.Where(a => a.idCita == idCita).ToList();
            var clientes = _db.Clientes.ToList();

            ViewBag.History = historial;
            ViewBag.Clientes = clientes;

            return View("HistoriaClinica");
        }  
   

        //[HttpPost]
        //public ActionResult HistoriaClinica(int idCita)
        //{
        //    var historial = _db.Historials.Where(a=>a.idCita==idCita).ToList();
        //    //var misHistorias = new List<Cita>();
        //    //var claim = HttpContext.User.Claims.FirstOrDefault();
        //    //var doctoresACargo = _db.Doctors.Where(o => o.usuario == claim.Value).FirstOrDefault(); //1
        //    //var idDocotr = doctoresACargo.idDoctor;
        //    //var citas = _db.Citas.Where(a=>a.idDoctor== idDocotr).ToList();

        //    //var historialpe = _db.Historials.Where(a=>a.idCita == citas.);
        //    //// citas.Select(a=>a.idCliente);
            
        //    //ViewBag.History = citas;
        //    ViewBag.historialpe = historial;
        //    return RedirectToAction("Index");
        //}

        
    }
}