using BaseClass._Library;
using BaseClass.ModelControllers;
using BaseClass.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public ActionResult Index(int hangsx_id=0, int page=1)
        {
            SanPhamController ctr = new SanPhamController();
            HangSXController ctr_hangsx = new HangSXController();
            HangSX hangsx = ctr_hangsx.get_by_id(hangsx_id);
            //check
            if (hangsx==null || hangsx.active==false)
            {
                return RedirectToAction("Index","FrontHome");
            }
            //pagination
            int max_item_per_page=4;//will get from setting
            //pagination
                PaginationLibrary pg = new PaginationLibrary();
                pg.set_current_page(page);
                pg.set_max_item_per_page(max_item_per_page);
                pg.set_total_item(
                    ctr.timkiem_count(
                    "",
                    "", 
                    "", 
                    "", 
                    0, 
                    0, 
                    hangsx,
                    "1")
                );
            pg.update();
            ViewBag.SanPham_List = ctr.timkiem(
                "",
                "",
                "",
                "",
                -1,
                -1,
                hangsx,
                "1",
                _timkiem_sanpham["order_by"],
                TextLibrary.ToBoolean(_timkiem_sanpham["order_desc"])
                ,pg.start_point,
                max_item_per_page);
            ViewBag.pagination = pg;
            ViewBag.hangsx = hangsx;
            return View();
        }
        [HttpGet]
        public ActionResult OrderBy(string order_by = "id", string order_desc = "1", int page = 1, int hangsx_id=0)
        {
            this._timkiem_sanpham["order_by"] = order_by;
            this._timkiem_sanpham["order_desc"] = order_desc;
            this._luu_timkiem_cookie();
            return RedirectToAction("Index", "FrontProducts", new { page = page, hangsx_id=hangsx_id });
        }
    }
}
