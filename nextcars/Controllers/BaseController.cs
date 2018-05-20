using nextcars.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nextcars.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            GetManufactures();
            GetBodyTypes();
            GetFuel();
            GetHotLaunch();
            GetVideoGallery_TestRide();
            GetVideoGallery_Comparison();
            GetVideoGallery_CrashTest();
            return base.BeginExecuteCore(callback, state);
        }
        public void GetManufactures()
        {
            HomeRepository repo = new HomeRepository();
            Session["Manufacture"] = repo.GetManufactures();
        }
        public void GetBodyTypes()
        {
            HomeRepository repo = new HomeRepository();
            Session["BodyType"] = repo.GetBodyTypes();
        }
        public void GetFuel()
        {
            HomeRepository repo = new HomeRepository();
            Session["Fuel"] = repo.GetFuel();
        }
        public void GetHotLaunch()
        {
            HomeRepository repo = new HomeRepository();
            Session["HotLaunch"] = repo.GetHotLaunch();
        }
        public void GetVideoGallery_TestRide()
        {
            HomeRepository repo = new HomeRepository();
            Session["TestDrives"] = repo.GetVideoGallery(2);
        }
        public void GetVideoGallery_Comparison()
        {
            HomeRepository repo = new HomeRepository();
            Session["ComparisonVideos"] = repo.GetVideoGallery(4);
        }
        public void GetVideoGallery_CrashTest()
        {
            HomeRepository repo = new HomeRepository();
            Session["CrashTestVideos"] = repo.GetVideoGallery(5);
        }
    }
}