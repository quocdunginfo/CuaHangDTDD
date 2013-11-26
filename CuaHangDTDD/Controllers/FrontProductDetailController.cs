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
    public class FrontProductDetailController : FrontController
    {
        /* 
         * Hiển thị thông tin chi tiết một sản phẩm
         * Hiển thị các màu sắc sản phẩm có
         * Cho phép đặt hàng Add To Cart tại đây
         */
        [HttpGet]
        public ActionResult Index(int id=0)
        {
            HangSXController ctr_hangsx = new HangSXController();
            SanPhamController ctr = new SanPhamController();
            SanPham obj = ctr.get_by_id(id);
            if (obj == null)
            {
                return RedirectToAction("Index","FrontHome");
            }
            ViewBag.sanpham = obj;
            return View();
        }
        [HttpPost]
        public ActionResult Submit()
        {
            SanPham_ChiTietController ctr = new SanPham_ChiTietController();
            int chitietsp_id = TextLibrary.ToInt(Request["sanpham_chitietsp_id"]);
            int soluong = TextLibrary.ToInt(Request["sanpham_soluong"]);
            SanPham_ChiTiet obj = ctr.get_by_id(chitietsp_id);
            if (obj == null || soluong>obj.tonkho)
            {
                return RedirectToAction("Index","FrontHome");
            }
            //new chi tiet don hang
                ChiTiet_DonHang chitiet_donhang = new ChiTiet_DonHang();
                chitiet_donhang.sanpham_chitiet = obj;
                chitiet_donhang.soluong = soluong;
                chitiet_donhang.dongia = obj.sanpham.gia;
            //call add to cart
                this._giohang._add_to_cart(chitiet_donhang);
            //save to session
                this._save_cart_to_session();
            return RedirectToAction("Index","FrontCart");
        }
        
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
    }
}
