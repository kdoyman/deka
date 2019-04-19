using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tip4trip_2.Models;
using System.Data.Entity;
namespace tip4trip_2.Controllers
{
    public class HomeController : Controller
    {
       private T4TContext db = new T4TContext();

        public ActionResult Index(string searching)
        {

            
            return View(db.Houses.Include(mmn => mmn.Location).Where(x => x.Location.nameloc.Contains(searching) || searching==null).ToList());
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