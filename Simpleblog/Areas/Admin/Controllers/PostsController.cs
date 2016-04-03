using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simpleblog.Areas.AdminAreaRegistration.Controllers
{
    public class PostsController : Controller
    {
        // GET: AdminAreaRegistration/Posts
        public ActionResult Index()
        {
            return Content("admin posts");
        }
    }
}