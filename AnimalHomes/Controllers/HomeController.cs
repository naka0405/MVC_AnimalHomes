using BuisnessLogic.Managers;
using DataAccess.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AnimalHomes.Controllers
{
    public class HomeController : Controller
    {

        //public async Task<ActionResult> Index()
        //{

        //    var authManager = HttpContext.GetOwinContext().Authentication;
        //    var auth = User.Identity.IsAuthenticated;

        //    //Employee user = userManager

        //}
        public ActionResult Index()
        {
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
}