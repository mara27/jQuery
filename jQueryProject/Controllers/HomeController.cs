using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jQueryProject.Models;

namespace jQueryProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //List<Gorila> listGoril = ListaGorile.getAll();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            var x =ListaGorile.listaDeGorile;
            return Json(x, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Insert(Gorila gorila)
        {
            ListaGorile.listaDeGorile.Add(gorila);
            return Json(new { status = "OK" });
        }

        public ActionResult ShowDetails(string name)
        {
            var gor = ListaGorile.listaDeGorile.First<Gorila>(x => x.Nume == name);
            return Json(gor, JsonRequestBehavior.AllowGet);
        }
    }
}
