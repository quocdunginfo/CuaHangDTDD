using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDTDD.Controllers
{
    public class FrontCartController : FrontController
    {
        //
        // GET: /FrontCart/

        public ActionResult Index()
        {
            return View();
        }

    }
}
