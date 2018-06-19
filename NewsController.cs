using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCbilibili.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Show(string ID)
        {
            
            ViewBag.ID = ID;
            return View();
        }



    }
}