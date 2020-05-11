using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResturantRater.Controllers
{
    public class ResturantController : Controller
    {
        // GET: Resturant/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}