using nextcars.dal;
using nextcars.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nextcars.Controllers
{
    public class CarDetailsController : BaseController
    {
        // GET: CarDetails
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            CarDiamention model = new CarDiamention();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(CarDiamention model)
        {
            if(ModelState.IsValid)
            {
                MasterRepository repo = new MasterRepository();
                repo.SaveCarDiamention(model);
                return RedirectToAction("Create");
            }
            else
            {
                return View(model);
            }
        }
    }
}