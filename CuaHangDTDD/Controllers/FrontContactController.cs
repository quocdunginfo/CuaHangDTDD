using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDTDD.Controllers
{
    public class FrontContactController : FrontController
    {
        /*Form để người dùng submit phản hồi*/
        public ActionResult Index()
        {
            return View();
        }

    }
}
