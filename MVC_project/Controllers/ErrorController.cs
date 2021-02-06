using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_project.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult ErrorInApp(int id)
        {
            Response.StatusCode = id;
            return View();
        }
    }
}