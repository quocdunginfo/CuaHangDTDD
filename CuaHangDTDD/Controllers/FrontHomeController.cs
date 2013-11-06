using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDTDD.Controllers
{
    public class FrontHomeController : FrontController
    {
        //
        // GET: /FrontHome/

        public ActionResult Index()
        {
            return View();
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

    }
}
