using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDTDD.Controllers
{
    public class FrontSearchController : FrontController
    {
        /*Hiển thị sản phẩm thỏa mãn điều kiện tìm kiếm
         Có phân trang và add to cart
         */
        public ActionResult Index()
        {
            return View();
        }

    }
}
