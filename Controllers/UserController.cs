using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyDentoWeb.BD;

namespace ProyDentoWeb.Controllers
{
    public class UserController : Controller
    {

        private readonly AppDBContext _db;

        public UserController(AppDBContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {

            var lst = _db.Users.ToList();

            return View(lst);
        }
    }
}
