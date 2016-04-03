using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simpleblog.Areas.AdminAreaRegistration.Controllers
{
    public class UserController : Controller
    {
        // GET: AdminAreaRegistration/User
        public ActionResult Index()
        {
            return Content("user");
        }
    }
}