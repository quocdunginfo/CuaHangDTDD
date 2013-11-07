using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuaHangDTDD.Controllers
{
    public class FrontProductsController : FrontController
    {
        /*
         * Hiển thị danh sách sản phẩm theo hãng SX có phân trang
         * Có nút Add to Cart => redirect đến trang Sản phẩm chi tiết để chọn
         * SL và màu sắc cần đặt
         */
        public ActionResult Index()
        {
            return View();
        }

    }
}
