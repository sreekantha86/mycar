using nextcars.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nextcars.Controllers
{
    public class VideoGalleryController : BaseController
    {
        // GET: VideoGallery
        public ActionResult Index()
        {
            HomeRepository repo = new HomeRepository();
            var model = repo.GetVideoCategory();
            Session["VideoCategory"] = model;
            return View();
        }

        public ActionResult ShowVideos(int? mfId, int? model, int? category)
        {
            HomeRepository repo = new HomeRepository();
            var data = repo.GetVideoGallery(mfId, model, category);
            return PartialView("_Videos", data);
        }
    }
}