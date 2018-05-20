using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nextcars.Controllers
{
    public class PopularCarBrandsController : BaseController
    {
        // GET: PopularCarBrands
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowPopularBrands()
        {
            return PartialView("_PopularBrands");
        }
    }
}