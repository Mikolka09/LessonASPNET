using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WA_2019_Net.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult show(int id)
        {
            ViewBag.Id = id;
            ViewBag.Title = id;
            //TODO:Обратимся к базе данных за записью 10
            return View();
        }

    }
   
}
