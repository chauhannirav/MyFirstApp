using MyFirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Stringconcate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Stringconcate(StringConcate strcon)
        {
            StringConcate sc = new StringConcate();
            int Id = sc.Id;
            string FirstName = sc.FirstName;
            string LastName = sc.LastName;
            string concate = string.Concat(FirstName, LastName);
            

            ViewBag.ToUpper = strcon.FirstName.ToLower() ;
            ViewBag.ToLower = strcon.LastName.ToUpper();
            ViewBag.Ltrim = strcon.FirstName.Trim();
            ViewBag.concate=strcon.FirstName  +  strcon.LastName;
            
            return View();
        }
        public ActionResult Polymorphism()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Polymorphism(Polymorphism Polymorp)
        {
            float radius=Polymorp.radius;
            ViewBag.Polymorp = Polymorp.radius;
            ViewBag.radius = (3.14 * radius * radius);
            return View();
        }
        public ActionResult boxingunboxing()
        {
            return View();
        }
        [HttpPost]
        public ActionResult boxingunboxing(boxingunboxing box)
        {
            object obj = box.name;
            ViewBag.obj = box.name.GetType();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    internal class Stringconcate
    {
        public static implicit operator Stringconcate(StringConcate v)
        {
            throw new NotImplementedException();
        }
    }
}