using Homes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homes.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Search()
        {
            
            var houses = new List<Addresse>();
            houses = Addresse.HouseReturnAll();

            return PartialView("_menu", houses);
        }
        [HttpPost]
        public ActionResult Search(string q)
        {
            string m = q;
            var houses = new List<Addresse>();
            houses = Addresse.HouseReturnAll();

            return PartialView("_menu", houses);
        }

    }
}