using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDTDD.Controllers
{
    public class FrontProductDetailController : FrontController
    {
        /* 
         * Hiển thị thông tin chi tiết một sản phẩm
         * Hiển thị các màu sắc sản phẩm có
         * Cho phép đặt hàng Add To Cart tại đây
         */
        public ActionResult Index()
        {
            return View();
        }

    }
}
