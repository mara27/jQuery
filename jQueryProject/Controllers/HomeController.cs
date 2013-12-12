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
        List<Gorila> listGoril = ListaGorile.getAll();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {

            return Json(listGoril, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Insert(Gorila gorila)
        {
            listGoril.Add(gorila);
            return Json(new { status = "OK" });
        }

        public ActionResult ShowDetails(int index)
        {
            return Json(listGoril[index], JsonRequestBehavior.AllowGet);
        }
    }
}
