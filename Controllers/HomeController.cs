using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    [Filters.Secret]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact( string id )
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact( ContactModel contact )
        {
            if( ModelState.IsValid )
            {
                ViewBag.Message = "Merci";
                return View();
            }
            else return View( contact );
        }

        [Filters.Secret]
        public ActionResult ContactList( string secret )
        {
            return View();
        }

    }
}