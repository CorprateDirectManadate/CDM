using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDM.FrontWeb.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Index()
        {
            return PartialView();
        } 
        public ActionResult HotelList()
        {
            return PartialView();
        }
    }
}