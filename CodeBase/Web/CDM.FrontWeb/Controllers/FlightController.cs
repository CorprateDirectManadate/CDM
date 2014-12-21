using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDM.FrontWeb.Controllers
{
    public class FlightController : Controller
    {
        // GET: Flight
        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult Flights_Detail()
        {
            return PartialView();
        } 
        public ActionResult Flights_Booking()
        {
            return PartialView();
        } 
        public ActionResult Flights_ThankYou()
        {
            return PartialView();
        }
    }
}