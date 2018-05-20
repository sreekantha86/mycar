using nextcars.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nextcars.Controllers
{
    //[RequireHttps]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult AutoComplete(string prefix)
        {
            HomeRepository repo = new HomeRepository();
            var Car = repo.GetCarByKeyWord(prefix);

            return Json(Car);
        }
        public ActionResult FillCars(int Id)
        {
            HomeRepository repo = new HomeRepository();
            return PartialView("_Models", repo.GetCars(Id));
        }
    }
}