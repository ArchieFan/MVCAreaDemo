using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAreaDemo.Areas.Employer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Employer/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}