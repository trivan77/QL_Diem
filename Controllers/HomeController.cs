using Database_IO;
using Database_Provider.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Point_Management.Controllers
{
     public class HomeController : Controller
     {
          public ActionResult Index()
          {
               DBIO db = new DBIO();
               STUDENT std = db.Get_Student_Inf("10000000");

               return View(std);
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