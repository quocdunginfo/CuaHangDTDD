using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDTDD.Controllers
{
    public class AdminHinhAnhController : Controller
    {
        /*Image upload gateway*/
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }

    }
}
