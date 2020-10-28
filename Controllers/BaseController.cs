using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyDentoWeb.BD;
using ProyDentoWeb.Models;

namespace ProyDentoWeb.Controllers
{
    public class BaseController : Controller
    {

        private readonly AppDBContext _db;

        
        public BaseController(AppDBContext db)
        {
            _db = db;
        }


        protected Cliente LoggedUser()
        {

            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = _db.Clientes.Where(o => o.usuario == claim.Value).FirstOrDefault();
            return user;
        }

        protected Doctor LoggedDoctor(){
             var claim = HttpContext.User.Claims.FirstOrDefault();
            var  doctor = _db.Doctors.Where(o => o.usuario == claim.Value).FirstOrDefault();

            return doctor;
        }

    }
}
