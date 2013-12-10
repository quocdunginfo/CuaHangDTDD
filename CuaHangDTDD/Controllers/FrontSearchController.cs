using BaseClass._Library;
using BaseClass.ModelControllers;
using BaseClass.Models;
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
        [HttpGet]
        public ActionResult Index(int page=1)
        {
            //controller
            SanPhamController ctr=new SanPhamController();
            HangSXController ctr_hangsx = new HangSXController();
            //varibles
            int gia_from = TextLibrary.ToInt(_timkiem_sanpham["gia_from"]);
            int gia_to = TextLibrary.ToInt(_timkiem_sanpham["gia_to"]);
            Boolean order_desc = TextLibrary.ToBoolean(_timkiem_sanpham["order_desc"]);
            int max_item_per_page= TextLibrary.ToInt(_timkiem_sanpham["max_item_per_page"]);
            int hang_sx_id = TextLibrary.ToInt(_timkiem_sanpham["hangsx_id"]);
            HangSX hangsx = ctr_hangsx.get_by_id(
                hang_sx_id
            );
            //pagination
            PaginationLibrary pagination = new PaginationLibrary();
            pagination.set_current_page(page);
            pagination.set_max_item_per_page(
                max_item_per_page   
            );
            
            pagination.set_total_item(
                ctr.timkiem_count(
                "",
                "",
                _timkiem_sanpham["ten"],
                "",
                gia_from,
                gia_to,
                hangsx,
                "1"
                )    
            );
            pagination.update();
            //View data
            ViewBag.SanPham_List = ctr.timkiem(
                "",
                "",
                _timkiem_sanpham["ten"],
                "",
                gia_from,
                gia_to,
                hangsx,
                "1",
                _timkiem_sanpham["order_by"],
                order_desc,
                pagination.start_point,
                pagination.max_item_per_page
            );
            ViewBag.pagination = pagination;
            return View();
        }
        [HttpGet]
        public ActionResult ViewAllProducts()
        {
            this._khoitao_timkiem_cookie();
            this._luu_timkiem_cookie();
            //redirect
            return RedirectToAction("Index", "FrontSearch");
        }
        [HttpPost]
        public ActionResult Submit()
        {
            //get search value
            if (!TextLibrary.ToString(Request["submit_reset"]).Equals(""))
            {
                //reset button click
                this._khoitao_timkiem_cookie();
            }
            else
            {
                //search button click
                this._timkiem_sanpham["ten"] = TextLibrary.ToString(Request["ten"]);
                this._timkiem_sanpham["gia_from"] = TextLibrary.ToString(Request["gia_from"]);
                this._timkiem_sanpham["gia_to"] = TextLibrary.ToString(Request["gia_to"]);
                
                this._timkiem_sanpham["hangsx_id"] = TextLibrary.ToString(Request["hangsx_id"]);
                this._timkiem_sanpham["max_item_per_page"] = TextLibrary.ToString(Request["max_item_per_page"]);
            }
            //Save respone cookies
            this._luu_timkiem_cookie();
            //redirect
            return RedirectToAction("Index", "FrontSearch");
        }
        [HttpGet]
        public ActionResult OrderBy(string order_by = "id", string order_desc = "1", int page=1)
        {
            this._timkiem_sanpham["order_by"] = order_by;
            this._timkiem_sanpham["order_desc"] = order_desc;
            this._luu_timkiem_cookie();
            return RedirectToAction("Index", "FrontSearch", new { page = page});
        }
        [HttpPost]
        public ActionResult Quick_Search()
        {
            string ten = TextLibrary.ToString(Request["ten"]);
            this._timkiem_sanpham["ten"] = ten;
            this._luu_timkiem_cookie();
            return RedirectToAction("Index","FrontSearch");
        }
    }
}
