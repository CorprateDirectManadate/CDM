using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDM.FrontWeb.Controllers
{
    public class CarController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}