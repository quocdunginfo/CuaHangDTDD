using BaseClass.ModelControllers;
using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDTDD.Controllers
{
    public class FrontHomeController : FrontController
    {
        /*Hiển thị Slideshow, 9 sản phẩm mới nhất, hiển thị danh mục hãng SX*/
        public ActionResult Index()
        {
            ViewBag.SanPham_List = new SanPhamController().timkiem("","","","",-1,-1,null,"1","id",true,0,8);
            return View();
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

    }
}
