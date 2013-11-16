﻿using BaseClass.ModelController;
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
            List<HangSX> search_hangsx = ctr_hangsx.timkiem(hangsx_id.ToString(),"","1");
            //check
            if (hangsx==null || hangsx.active==false)
            {
                return RedirectToAction("Index","FrontHome");
            }
            //pagination
            int max_item_per_page=4;//will get from setting
            //pagination
                Pagination pg = new Pagination();
                pg.set_current_page(page);
                pg.set_max_item_per_page(max_item_per_page);
                pg.set_total_item(
                    ctr.timkiem_count("", "", "", "", -1, -1, search_hangsx, "1")
                );
            pg.update();
            ViewBag.SanPham_List = ctr.timkiem("","","","",-1,-1,search_hangsx,"1","id",true,pg.start_point,max_item_per_page);
            ViewBag.pagination = pg;
            ViewBag.hangsx = hangsx;
            return View();
        }

    }
}
