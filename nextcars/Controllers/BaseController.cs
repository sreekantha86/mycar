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
            GetVideoGallery();
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
        public void GetVideoGallery()
        {
            HomeRepository repo = new HomeRepository();
            Session["TestDrives"] = repo.GetVideoGallery();
        }
    }
}