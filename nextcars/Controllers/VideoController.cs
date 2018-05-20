using nextcars.dal;
using nextcars.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nextcars.Controllers
{
    public class VideoController : BaseController
    {
        // GET: Video
        public ActionResult Index()
        {
            HomeRepository repo = new HomeRepository();
            var model = repo.GetVideoCategory();
            Session["VideoCategory"] = model;
            return View();
        }
        public ActionResult Create()
        {
            HomeRepository repo = new HomeRepository();
            var model = repo.GetVideoCategory();
            Session["VideoCategory"] = model;
            return View();
        }
        [HttpPost]
        public ActionResult Create(CarVideos model)
        {
            if(ModelState.IsValid)
            {
                model.vidURL = model.vidURL.Replace("https://youtu.be/", "https://www.youtube.com/embed/");
                model.vidTypeId = 2;
                MasterRepository repo = new MasterRepository();
                repo.SaveCarVideo(model);
                return RedirectToAction("Create");
            }
            else
            {
                return View(model);
            }            
        }
    }
}