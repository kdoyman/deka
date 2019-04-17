using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tip4trip_2.Models;

namespace tip4trip_2.Controllers
{
    public class HomeController : Controller
    {
       private T4TContext db = new T4TContext();

        public ActionResult Index(string searching)
        {

            
            return View(db.Houses.Where(x=>x.Address.Contains(searching) || searching==null).ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.not";
           
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.nooot";

            return View();
        }
    }
}